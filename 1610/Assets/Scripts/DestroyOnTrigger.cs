using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
	public float DeathTime;
	public float RespawnTime;

	
	IEnumerator OnTriggerEnter(Collider other)
	{
		yield return new WaitForSeconds(DeathTime);
        Destroy(gameObject);
	}
}
