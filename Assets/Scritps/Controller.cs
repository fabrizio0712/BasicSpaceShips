using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Controller : MonoBehaviour, IMovile
{
    private Rigidbody2D rb;

    public void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    public void Move(Vector2 dir, float speed)
    {
        rb.velocity = dir * speed;
    }
    public void Attack(Weapon weapon, Vector2 dir, GameObject bullet, Transform shooter)
    {
        weapon.Attack(shooter, dir, bullet);
    }        
    public float GetDamage(float Damage, float CurrentLife) 
    {
        CurrentLife -= Damage;
        return CurrentLife;
    }

}