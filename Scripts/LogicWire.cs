using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicWire : MonoBehaviour
{
    private float Value;
    public float LineValue
    {
        get
        {
            return Value;
        }
        set
        {
            Value = value;
        }
    }
    public bool LineBool
    {
        get
        {
            return Value > 0;
        }
        set
        {
            if (value)
                Value = 1;
            else
                Value = -1;
        }
    }
    public bool LineNeutral
    {
        get
        {
            return Value == 0;
        }
    }
}
