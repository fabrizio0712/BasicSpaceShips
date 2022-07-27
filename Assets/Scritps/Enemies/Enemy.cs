using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor
{
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected GameObject turret;
    [SerializeField] protected bool imBoss;
    protected IALogic logic;

    private void Awake()
    {
        logic = gameObject.GetComponent<IALogic>();
        controller = gameObject.GetComponent<Controller>();
        currentDir = Vector2.zero;
        currentLife = stats.Life;
        currentSpeed = stats.Speed;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (transform.position.y < 5) logic.AttackEnable = true;
        controller.Move(logic.CalculateDirection(gameObject, imBoss), currentSpeed);
        if (logic.CanAttack()) controller.Attack(weapon, new Vector2(0,-1), bullet, turret.transform);
        if (transform.position.y < -6.5) gameObject.SetActive(false);
    }
}
