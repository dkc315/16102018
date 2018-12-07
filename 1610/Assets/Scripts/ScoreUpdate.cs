using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{

	public FloatData Score;
	public FloatData Health;
	public FloatData AltAmmo;

	void Start ()
	{
		Health.Value = 1;
		Score.Value = 0;
		AltAmmo.Value = 0;
		StartCoroutine(Time());
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
