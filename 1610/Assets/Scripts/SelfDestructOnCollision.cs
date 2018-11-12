using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructOnCollision : MonoBehaviour
{
	private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
	}
}
