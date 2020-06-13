using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Obsolete("", true)]
public class BulletServiceSimple : BulletServiceBase
{
    public Bullet bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _service = this;
    }

    public override Bullet GetBullet()
    {
        Bullet bullet = Instantiate(bulletPrefab);
        StartCoroutine(DestroyBullet(bullet));
        return bullet;
    }

    IEnumerator DestroyBullet(Bullet bullet)
    {
        yield return new WaitForSeconds(4f);
        Destroy(bullet.gameObject);
    }
}
