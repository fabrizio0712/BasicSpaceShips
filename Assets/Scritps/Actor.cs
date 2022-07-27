using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller))]
public class Actor : MonoBehaviour
{
    [SerializeField] protected ActorStats stats;
    [SerializeField] protected Weapon weapon;
    protected Controller controller;
    protected float currentLife;
    protected float currentSpeed;
    protected Vector2 currentDir;
    protected Animator anim;

    public void GetDamage(float damage) 
    {
        currentLife -= damage;
        if (currentLife <= 0) 
        {
            gameObject.SetActive(false);
        }
    }
}
