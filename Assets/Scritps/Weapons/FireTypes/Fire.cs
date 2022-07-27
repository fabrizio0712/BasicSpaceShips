using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fire : MonoBehaviour, IAttack
{
    protected BulletFactory bulletFactory;
    public abstract void Attack(WeaponStats stats, Transform shooter, Vector2 dir, GameObject bullet);
}
