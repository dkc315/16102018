using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover2D : MonoBehaviour
{
	private CharacterController controller;
	public float Gravity;
	public float MoveSpeed;
	public float JumpSpeed;
	private Vector3 position, rotation;
	private bool flipped;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		position = transform.TransformDirection(position);
		position.x = MoveSpeed * Input.GetAxis("Horizontal");
		position.z = 0;

		if (controller.isGrounded)
		{	

			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}
		
		position.y -= Gravity * Time.deltaTime;
		controller.Move(position * Time.deltaTime);

		if (Input.GetKey(KeyCode.A) && !flipped)
		{
			transform.Rotate(0, 180, 0);
			flipped = true;
		}
		
		if (Input.GetKey(KeyCode.D) && flipped)
		{
			transform.Rotate(0, 180, 0);
			flipped = false;
		}
	}
}
