using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public CharacterController StickGuy;

    public Vector2 MoveSpeed;
    public Vector2 RotateSpeed;
    public float Speed;


	// Update is called once per frame
	void Update () {
        MoveSpeed.x += Speed * Input.GetAxis("Horizontal");
        MoveSpeed.y += Speed * Input.GetAxis("Vertical");
        MoveSpeed *= Time.deltaTime;

        StickGuy.Move(MoveSpeed);
	}
}
