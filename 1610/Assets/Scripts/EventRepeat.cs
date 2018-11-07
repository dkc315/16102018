using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRepeat : MonoBehaviour
{

	public UnityEvent[] OnRepeat;
	public float WaitTime;
	private int i;
	
	IEnumerator Start () {
		while (true)
		{
			yield return new WaitForSeconds(WaitTime);
			OnRepeat [i].Invoke();
			if (i < OnRepeat.Length-1)
			{
				i++;
			}
			else
			{
				i = 0;
			}
		}
	}
}
