using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    public void Fire(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = speed * direction;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
