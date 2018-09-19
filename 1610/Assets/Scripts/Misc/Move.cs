using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public CharacterController Character;
	
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	public float Speed;
	
	void Update ()
	{
		MoveSpeed.x += Speed*Input.GetAxis("Horizontal");
		MoveSpeed.y += Speed*Input.GetAxis("Vertical");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
	}
}
