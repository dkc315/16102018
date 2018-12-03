using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject Instance;
	public float Rate;
	
	IEnumerator Start () 
	{
		for (;;)
		{
			Instantiate(Instance, transform.position, transform.rotation);
			yield return new WaitForSeconds(Rate);
		}
	}

}
