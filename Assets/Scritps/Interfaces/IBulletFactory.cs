using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBulletFactory : IFactory
{
    
    void CreateBullet(GameObject bullet, Transform shooter, float speed, Vector3 direction);
}
