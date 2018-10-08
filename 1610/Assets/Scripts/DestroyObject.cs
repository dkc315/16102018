using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

	public float Lifetime;
	
	IEnumerator Start ()
	{
		yield return new WaitForSeconds(Lifetime);
		Destroy(gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}
