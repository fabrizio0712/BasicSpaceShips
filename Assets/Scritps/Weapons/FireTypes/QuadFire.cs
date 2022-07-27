using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadFire : Fire
{
    [SerializeField] private float spreadAngle;
    private float currentTime = 0;

    

    public override void Attack(WeaponStats stats, Transform shooter, Vector2 dir, GameObject bullet) 
    {
        if (bulletFactory == null) 
        {
            bulletFactory = new BulletFactory();
        }
        if (currentTime > 1/stats.FireRate)
        {
            for (int i = 0; i < stats.BulletAmount; i++)
            {
                float aux = 90 - (spreadAngle / 2) + (i * spreadAngle / (stats.BulletAmount - 1));
                Vector2 auxVect = new Vector2(Mathf.Cos(aux * Mathf.PI / 180), dir.y * Mathf.Sin(aux * Mathf.PI / 180));
                bulletFactory.CreateBullet(bullet, shooter, stats.BulletSpeed, auxVect);
            }
            currentTime = 0;
        }
        else 
        {
            currentTime += Time.deltaTime;
        }

    }
}
