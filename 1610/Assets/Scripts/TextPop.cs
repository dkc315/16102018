using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPop : MonoBehaviour
{
	public FloatData Data;

	private Text text;
	private string function;
	public bool Add, Subtract, Multiply, Divide;

	private void Start()
	{
		text = GetComponent<Text>();
	}

	private void OnTriggerEnter(Collider other)
	{
		Data.Value.ToString();
		text.text = function + Data.Value;
		if (Add)
		{
			function = "+";
		}

		if (Subtract)
		{
			function = "-";
		}

		if (Multiply)
		{
			function = "x";
		}

		if (Divide)
		{
			function = "/";
		}
		Show();
	}

	IEnumerator Show()
	{
		
		yield return new WaitForSeconds(3);
		
	}

	
}
