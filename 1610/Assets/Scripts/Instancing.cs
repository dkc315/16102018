using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{
	public GameObject Instance, AltInstance;
	public FloatData Consumable, AltConsumable, ConsumeRate, AltConsumeRate;
    public float AltWaitTime, WaitTime;
	public bool PauseToggle;
   
	void Start()
	{
		StartCoroutine(AltFire());
		StartCoroutine(Fire());
	}

	IEnumerator AltFire()
	{

		while (true)
		{
			if (PauseToggle == false && Input.GetMouseButton(1) && AltConsumable.Value >= AltConsumeRate.Value)
			{
				Instantiate(AltInstance, transform.position, transform.rotation);
				AltConsumable.Value = AltConsumable.Value - AltConsumeRate.Value;
				yield return new WaitForSeconds(AltWaitTime);
			}
			yield return null;
		}
	}

	IEnumerator Fire()
	{	
		while (true)
		{
			if (PauseToggle == false && Input.GetMouseButtonDown(0) /*&& Consumable.Value >= ConsumeRate.Value*/)
			{
				Instantiate(Instance, transform.position, transform.rotation);
				//Consumable.Value = Consumable.Value - ConsumeRate.Value;
				yield return new WaitForSeconds(WaitTime);
			}
			yield return null;
		}
	}
}
