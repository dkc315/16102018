using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class IfStatments : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;

	public NameId Lock, Key;


	void Update()
	{
		if (Lock==Key)
		{
			print("Unlock Door");
		}
		
		if (LightOn)
		{
			print("The LIGHT is on!");
		}
		else
		{
			print("LIGHTS OUT BOI");
		}

		if (Password != "URMOM")
		{
			print("NO U");
		}
		else
		{
			print("REEEEEEEEEEEEEEEEEEEEEE");
		}

		if (A == B + C && B < C)
		{
			print(Password);

		}
	}
}
