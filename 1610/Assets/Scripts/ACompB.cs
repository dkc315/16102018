using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACompB : MonoBehaviour {

    public NameId A, B;

    void Update ()
    {
        if (A == B)
        {
            print("The Lock clicks Open");
        }

        if (A != B)
        {
            print("The Door is Locked");
        }
    }
}
