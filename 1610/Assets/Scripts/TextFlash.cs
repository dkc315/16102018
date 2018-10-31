using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
using UnityEngine;
using UnityEngine.UI;

public class TextFlash : MonoBehaviour
{
    public Canvas Canvas;
    public Text Text;
    public FloatData Data;
    public string Function;
    public float Lifetime;

    IEnumerator OnTriggerEnter(Collider other)
    {
        Text.text = Function + Data.Value;
        Canvas.enabled = true;
        yield return new WaitForSeconds(Lifetime);
        Canvas.enabled = false;
        
    }
   
}
