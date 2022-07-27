using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : Enemy
{
    [SerializeField] Weapon weapon2;
    [SerializeField] GameObject turret1;
    [SerializeField] GameObject turret2;

    protected override void Update()
    {
        base.Update();
        if (logic.CanAttack()) 
        {
            controller.Attack(weapon2, new Vector2(0,-1), bullet, turret1.transform);
            controller.Attack(weapon2, new Vector2(0,-1), bullet, turret2.transform);
        }
    }
}
