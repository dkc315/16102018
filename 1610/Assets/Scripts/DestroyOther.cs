using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour 
{

	public float Lifetime;
	public FloatData Score;
	
	IEnumerator Start ()
	{
		yield return new WaitForSeconds(Lifetime);
		Destroy(gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(other.gameObject);
		Score.Value += 100;
	}
}
