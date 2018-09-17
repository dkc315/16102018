using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveXZ : MonoBehaviour {
	
	public CharacterController Character;
	
	public Vector3 MoveSpeed;
	public float Speed;
	
	void Update ()
	{
		MoveSpeed.x += Speed*Input.GetAxis("Horizontal");
		MoveSpeed.z += Speed*Input.GetAxis("Vertical");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
	}
}
