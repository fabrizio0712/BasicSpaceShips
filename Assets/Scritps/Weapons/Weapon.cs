using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected WeaponStats stats;
    public void Attack(Transform shooter, Vector2 dir, GameObject bullet)
    {
        stats.ShotStrategy.Attack(stats, shooter, dir, bullet);
    }
}
