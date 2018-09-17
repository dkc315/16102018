using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

	public bool IsAWizard;
	
	public int AmmoCount = 100;
	public int InventoryCount;

	public float Health = 1.0f;
	public float Money = 5.0f;

	public string PlayerName;
	public string Team = "Wolves";

	public Vector3 Location;
	
	
	
	// Use this for initialization
	void Start ()
	{
		print(PlayerName + " is on team " + Team);
		
		
		if (Money >= 500.0f)
		{
			print(PlayerName + " is filthy rich!");
		}
		else
		{
			print(PlayerName + " is a broke boy!");
		}
		
		
		
		if (IsAWizard)
		{
			print(PlayerName + " is a wizard!");
		}
		else
		{
			print(PlayerName + " is a filthy casual");
		}


		if (AmmoCount >= 100)
		{
			print(PlayerName + " is armed and dangerous!");
		}
		else
		{
			print(PlayerName + " is unarmed!");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
