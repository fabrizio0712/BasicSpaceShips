using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack 
{
    void Attack(WeaponStats stats, Transform shooter, Vector2 dir, GameObject bullet);
}
