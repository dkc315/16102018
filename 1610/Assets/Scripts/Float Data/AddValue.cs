using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{

    public FloatData ValueObj, ValueTar, MinValue, MaxValue;
    public UnityEvent Event, EventMin, EventMax;

    // Math
    public void AddValueToObject(FloatData data)
    {
        // Range
        if (ValueObj.Value >= MinValue.Value && ValueObj.Value <= MaxValue.Value)
        {
                ValueObj.Value += data.Value;

                Update();
        }
    }
    public void SubtractValueFromObject(FloatData data)
    {
        // Range
        if (ValueObj.Value >= MinValue.Value && ValueObj.Value <= MaxValue.Value)
        {
                ValueObj.Value -= data.Value;

                Update();
        }
    }
    public void MultiplyValueByObject(FloatData data)
    {
        // Range
        if (ValueObj.Value >= MinValue.Value && ValueObj.Value <= MaxValue.Value)
        {
                ValueObj.Value *= data.Value;

                Update();
        }
    }
    public void DivideValueByObject(FloatData data)
    {
        // Range
        if (ValueObj.Value >= MinValue.Value && ValueObj.Value <= MaxValue.Value)
        {
                ValueObj.Value /= data.Value;

                Update();
        }
    }

    void Update()
    {
        // Cap
        if (ValueTar.Value>= ValueObj.Value)
        {
            ValueTar.Value = ValueObj.Value;
        }

        // Floor
        if (ValueTar.Value <= ValueObj.Value)
        {
            ValueTar.Value = ValueObj.Value;
        }
    }
}