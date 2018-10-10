using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
    string Name;

    public void Call()
    {
        Name = "Bob";
        print(Name);
    }

    public void Call(string newName)
    {
        newName = "Freeeeee";
        print(newName);
        print(Name);
    }
}
