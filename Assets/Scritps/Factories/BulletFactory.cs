using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : Spawner, IBulletFactory
{
    private GameObject newBullet;
    public void CreateBullet(GameObject bullet, Transform shooter, float speed,Vector3 direction)
    {
        newBullet = GameObject.Instantiate(bullet);
        newBullet.transform.position = shooter.position;
        newBullet.GetComponent<Bullet>().SetStats(speed, direction);
    }
}
