using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTriggerSprite : MonoBehaviour {

	public float DeathTime;
	public float RespawnTime;
	private SpriteRenderer renderer;
	private BoxCollider collider;
	
	private void Start()
	{
		renderer = GetComponent<SpriteRenderer>();
		collider = GetComponent<BoxCollider>();
	}

	IEnumerator OnTriggerEnter(Collider other)
	{
		yield return new WaitForSeconds(DeathTime);
		renderer.enabled = false;
		collider.enabled = false;
		
		yield return new WaitForSeconds(RespawnTime);
		renderer.enabled = true;
		collider.enabled = true;
	}
}
