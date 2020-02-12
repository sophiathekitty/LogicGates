using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LogicGate : MonoBehaviour
{
    public LogicWire Output; // output line
    public abstract void Transmit();
    private void Update()
    {
        Transmit();
    }

}
