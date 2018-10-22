using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TextPop : MonoBehaviour
{
	public FloatData Data;

	public Text Text;
	private string function;
	public Canvas Canvas;
	public bool Add, Subtract, Multiply, Divide;

	private void Start()
	{
		Canvas.enabled = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		Data.Value.ToString();
		Text.text = function + Data.Value;
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
		Canvas.enabled = true;
		yield return new WaitForSeconds(2);
		Canvas.enabled = false;
	}
}
