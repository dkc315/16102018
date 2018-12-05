using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{

	public FloatData Score;
	public FloatData Health;

	void Start ()
	{
		StartCoroutine(Time());
	}
	
	void Update () {
		
	}

	private IEnumerator Time()
	{
		while (Health.Value > 0)
		{
			yield return new WaitForSeconds(2);
			Score.Value += 10;
		}
	}
}
