using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{
	public GameObject Instance, AltInstance;
	public FloatData Consumable, AltConsumable, ConsumeRate, AltConsumeRate;
    public float WaitTime;
   
	void Start()
	{
		StartCoroutine(AltFire());
		StartCoroutine(Fire());
	}

	IEnumerator AltFire()
	{

		while (true)
		{
			if (Input.GetMouseButton(1))
			{
				if (AltConsumable.Value >= AltConsumeRate.Value)
				{
					Instantiate(AltInstance, transform.position, transform.rotation);
					AltConsumable.Value = AltConsumable.Value - AltConsumeRate.Value;
					yield return null;
				}
			}
		}
	}

	IEnumerator Fire()
	{	
		while (true)
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (Consumable.Value >= ConsumeRate.Value)
				{
					Instantiate(Instance, transform.position, transform.rotation);
					Consumable.Value = Consumable.Value - ConsumeRate.Value;
					yield return null;
				}
			}
		}
	}
}
