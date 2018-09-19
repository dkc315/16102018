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

    public void AddValueToObject(FloatData data)
    {
        ValueObj.Value += data.Value;

        if (ValueObj.Value <= 0)
        {
            Event.Invoke();
        }

        if (ValueObj.Value >= MaxValue.Value)
        {
            Event.Invoke();
        }

        if (ValueObj.Value <= MinValue.Value)
        {
            Event.Invoke();
        }
    }
}