using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockGate : LogicGate
{
    public LogicWire InputA;
    public float Interval;
    private float interval_time;
    public override void Transmit()
    {
        if(InputA == null || InputA.LineBool)
        {
            interval_time -= Time.deltaTime;
            if(interval_time < 0)
            {
                interval_time = Interval;
            }
            Output.LineBool = (interval_time < Interval / 2);
        }
    }
}
