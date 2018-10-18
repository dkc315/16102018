using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextValue : MonoBehaviour
{

	public FloatData Data;
	private Text text;
	private string StringText;
	
	void Start ()
	{
		text = GetComponent<Text>();
	}

	void Update ()
	{
		StringText = Data.Value.ToString();
		text.text = StringText;
	}
}
