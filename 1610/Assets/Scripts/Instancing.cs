using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;
	public float WaitTime;

	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(Instance, transform.position, transform.rotation);
			
		}
	}
}
