using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject Instance;
	public float Rate, ActivationTime, UpgradeTime, UpgradeRate;
	
	IEnumerator Start () 
	{
		yield return new WaitForSeconds(ActivationTime);
		StartCoroutine(Spawn());
		while (true)
		{
			yield return new WaitForSeconds(UpgradeTime);
			Rate -= UpgradeRate;
		}
	}

	IEnumerator Spawn()
	{
		for (;;)
		{
			Instantiate(Instance, transform.position, transform.rotation);
			yield return new WaitForSeconds(Rate);
		}
	}

}
