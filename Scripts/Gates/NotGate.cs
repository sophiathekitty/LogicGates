using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : LogicGate
{
    public LogicWire InputA;

    public override void Transmit()
    {
        Output.LineBool = !InputA.LineBool;
    }
}
