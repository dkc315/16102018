using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{
	public GameObject Instance, AltInstance;
	public FloatData Consumable, AltConsumable, ConsumeRate, AltConsumeRate;
    public float WaitTime;
   
	void Update ()
	{
        if (Input.GetMouseButtonDown(0))
        {
            if (Consumable.Value >= ConsumeRate.Value)
            {
                Instantiate(Instance, transform.position, transform.rotation);
                Consumable.Value = Consumable.Value - ConsumeRate.Value;
            }
        }

		if (Input.GetMouseButton(1))
		{
            if (AltConsumable.Value >= AltConsumeRate.Value)
            {
                Instantiate(AltInstance, transform.position, transform.rotation);
                AltConsumable.Value = AltConsumable.Value - AltConsumeRate.Value;
            }
        }
	}
}
