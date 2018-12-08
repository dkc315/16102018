using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{

	public GameObject Instance;
	public float Rate, ActivationTime, UpgradeTime, UpgradeRate;
	public UnityEvent Event;

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
			Event.Invoke();
			yield return new WaitForSeconds(Rate);
		}
	}

}
