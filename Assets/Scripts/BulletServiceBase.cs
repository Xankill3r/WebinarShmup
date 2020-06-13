using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletServiceBase : MonoBehaviour
{
    protected static BulletServiceBase _service;
    public static BulletServiceBase GetService()
    {
        return _service;
    }

    public abstract Bullet GetBullet();
}
