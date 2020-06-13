using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPilot : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        GetComponent<Ship>().Move(new Vector2(horizontal, 0f));
        if (Input.GetButton("Fire1"))
        {
            GetComponent<Ship>().FireBullet(Vector2.up);
        }
    }
}
