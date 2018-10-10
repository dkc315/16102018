using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt : ScriptableObject
{
    private float health;
    protected float PowerLevel;
    public float EnergyLevel;

    private void AddHelath()
    {
        health += 100;
    }

    protected void AddPower()
    {
        AddHelath();
    }

    public void AddEnergy()
    {
        
    } 
}

public class ICanSeeIt : MonoBehaviour
{
    private WhatCanSeeIt newObject;

    private void Start()
    {
        newObject.EnergyLevel = 100;
        newObject.AddEnergy();
    }
}

public class Child : WhatCanSeeIt
{
    void CallThings()
    {
        PowerLevel = 100;
        EnergyLevel = 200;
        AddPower();
        AddEnergy();
    }
}