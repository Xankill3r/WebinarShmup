using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 5f;

    float lastTimeFired = 0f;
    public float bulletDelay = 1f;

    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = speed * direction;
    }

    public void FireBullet(Vector2 direction)
    {
        if (lastTimeFired + bulletDelay <= Time.time)
        {
            lastTimeFired = Time.time;
            Bullet bullet = BulletServiceBase.GetService().GetBullet();
            bullet.Fire(direction);
            bullet.transform.position = transform.position;
            bullet.gameObject.layer = gameObject.layer;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        GameServiceBase.GetService().ShipDestroyed(this);
    }
}
