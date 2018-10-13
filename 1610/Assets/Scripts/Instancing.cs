using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;
	public GameObject AltInstance;
	 public FloatData Consumable;
    public FloatData ConsumeRate;
    public float WaitTime;
   

	void Update ()
	{
        if (Input.GetMouseButtonDown(0))
        {
            if (Consumable.Value >= 1)
            {
                Instantiate(Instance, transform.position, transform.rotation);
                Consumable.Value = Consumable.Value - ConsumeRate.Value;
            }
        }

		if (Input.GetMouseButton(1))
		{
            if (Consumable.Value >= 1)
            {
                Instantiate(AltInstance, transform.position, transform.rotation);
                Consumable.Value = Consumable.Value - ConsumeRate.Value;
            }
        }
	}
}
