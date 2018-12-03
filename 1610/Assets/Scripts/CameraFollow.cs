using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public GameObject Player;
	public Vector3 Offset;

	// Update is called once per frame
	void Update ()
	{
		transform.position = Player.transform.position + Offset;
	}
}
