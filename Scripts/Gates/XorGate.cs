using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XorGate : LogicGate
{
    public LogicWire InputA;
    public LogicWire InputB;

    public override void Transmit()
    {
        Output.LineBool = (InputA.LineBool || InputB.LineBool) && (InputA.LineBool != InputB.LineBool);
    }
}
