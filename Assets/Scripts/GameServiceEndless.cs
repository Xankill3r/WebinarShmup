using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameServiceEndless : GameServiceBase
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        _service = this;
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn ships here
    }

    public override void ShipDestroyed(Ship ship)
    {
        if (!ship.gameObject.CompareTag("Player"))
        {
            score++;
        }
    }
}
