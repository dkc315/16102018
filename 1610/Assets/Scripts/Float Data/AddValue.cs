using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{

    public FloatData ValueObj;
    public FloatData MaxValue;
    public FloatData MinValue;

    public UnityEvent Event;
    public UnityEvent EventMax;
    public UnityEvent EventMin;


    // Math
    public void AddValueToObject(FloatData data)
    {

        // Range
        if (ValueObj.Value >= MinValue.Value)
        {
            if (ValueObj.Value <= MaxValue.Value)
            {
                ValueObj.Value += data.Value;
            }
        }
       
    }
    public void SubtractValueFromObject(FloatData data)
    {

        // Range
        if (ValueObj.Value >= MinValue.Value)
        {
            if (ValueObj.Value <= MaxValue.Value)
            {
                ValueObj.Value -= data.Value;
            }
        }
    }
    public void MultiplyValueByObject(FloatData data)
    {

        // Range
        if (ValueObj.Value >= MinValue.Value)
        {
            if (ValueObj.Value <= MaxValue.Value)
            {
                ValueObj.Value *= data.Value;
            }
        }
    }
    public void DivideValueByObject(FloatData data)
    {

        // Range
        if (ValueObj.Value >= MinValue.Value)
        {
            if (ValueObj.Value <= MaxValue.Value)
            {
                ValueObj.Value /= data.Value;
            }
        }
    }

    void Update()
    {
          // Cap
           if (ValueObj.Value >= MaxValue.Value)
           {
               ValueObj.Value = MaxValue.Value;
           }

           // Floor
           if (ValueObj.Value <= MinValue.Value)
           {
                ValueObj.Value = MinValue.Value;
           }
        
    } 
}