using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameServiceBase : MonoBehaviour
{
    protected static GameServiceBase _service;
    public static GameServiceBase GetService()
    {
        return _service;
    }

    public abstract void ShipDestroyed(Ship ship);
}
