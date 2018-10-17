using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
	public float DeathTime;
	public float RespawnTime;
	public MeshRenderer Renderer;
	public BoxCollider Collider;
	
	private void Start()
	{
		Renderer = GetComponent<MeshRenderer>();
		Collider = GetComponent<BoxCollider>();
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		yield return new WaitForSeconds(DeathTime);
		Renderer.enabled = false;
		Collider.enabled = false;
		
		yield return new WaitForSeconds(RespawnTime);
		Renderer.enabled = true;
		Collider.enabled = true;
	}
}
