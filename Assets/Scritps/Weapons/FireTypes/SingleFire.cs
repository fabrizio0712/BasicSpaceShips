using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFire : Fire
{
    private float currentTime = 0;
   
    public override void Attack(WeaponStats stats, Transform shooter, Vector2 dir, GameObject bullet) 
    {
        if (bulletFactory == null)
        {
            bulletFactory = new BulletFactory();
        }
        if (currentTime > 1/stats.FireRate)
        {
            bulletFactory.CreateBullet(bullet, shooter, stats.BulletSpeed, dir);
            currentTime = 0;
        }
        else 
        {
            currentTime += Time.deltaTime;
        }
        
    }
}
