using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables2 : MonoBehaviour {

    // Stats
    public int Health = 100;
    public int Money  = 0;
    public int Mana   = 100;

    // Classes
    public bool IsAWizard;
    public bool IsAKnight;
    public bool IsAArcher;

    // Teams and Labels
    public string PlayerName;
    public string Team;
    


	// Use this for initialization
	void Start () {
        print(PlayerName + " is on team " + Team + ".");
        print(PlayerName + " has " + Money + " gold.");


        // I'm aware that there are way better ways to do this
        if (IsAWizard)
            print(PlayerName + " is a Wizard!");
        else
            if (IsAKnight)
            print(PlayerName + "is a Knight!");
        else
            if (IsAArcher)
            print(PlayerName + "is an archer!");
        else print(PlayerName + "is a peasent!");
	}
}
