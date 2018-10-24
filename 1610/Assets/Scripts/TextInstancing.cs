using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
using UnityEngine;
using UnityEngine.UI;

public class TextInstancing : MonoBehaviour
{
    public Canvas Canvas;
    public Text Text;
    public FloatData Data;
    public string Function;
    public float Lifetime;

    private void OnTriggerEnter(Collider other)
    {
        Text.text = Function + Data.Value;
        Delay();
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(Lifetime);
        Text.text = "";
    }
   
}
