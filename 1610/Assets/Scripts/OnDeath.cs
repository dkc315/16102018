using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OnDeath : MonoBehaviour
{
	public FloatData Heatlh;
	public UnityEvent Event;

	void Start ()
	{

	}
	

	void Update () {
		if (Heatlh.Value <= 0)
		{
			Event.Invoke();
		}
	}
}
