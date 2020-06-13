using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPilot : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Ship>().Move(Vector2.down);
        GetComponent<Ship>().FireBullet(Vector2.down);
    }
}
