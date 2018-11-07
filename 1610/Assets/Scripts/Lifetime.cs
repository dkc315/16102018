using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour {

	public float Time;
	
	IEnumerator Start ()
	{
		yield return new WaitForSeconds(Time);
		Destroy(gameObject);
	}
}
