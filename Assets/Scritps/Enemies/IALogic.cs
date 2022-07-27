using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IALogic : MonoBehaviour
{
    [SerializeField] private float linearMoveLimit;
    [SerializeField] private float nonAttackTime;
    [SerializeField] private float attackTime;
    [SerializeField] private float lockMovingTime;
    private float currentAttakingTime = 0;
    private float currentNonAttakingTime = 0;
    private float currentLockMovingTime = 0;
    private bool signal = false;
    private bool attackEnable = false;
    private bool startSecondMove = false;
    private Vector3 direction = Vector3.zero;

    public bool AttackEnable { get => attackEnable; set => attackEnable = value; }

    public virtual Vector3 CalculateDirection(GameObject me, bool imboss) 
    {
        if (me.transform.position.y > linearMoveLimit) direction = new Vector3(0, -1, 0);
        else 
        {
            if (imboss)
            {
                if (transform.position.y < 5.5 && transform.position.y > 1.5 && transform.position.x < 5.5 && transform.position.x > -5.5)
                {
                    if (currentLockMovingTime > lockMovingTime)
                    {
                        direction = new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), 0);
                        currentLockMovingTime = 0;
                    }
                    else
                    {
                        currentLockMovingTime += Time.deltaTime;
                    }
                }
                else
                {
                    if (transform.position.y > 5.5) direction = new Vector3(direction.x, -1, 0);
                    else if (transform.position.y < 1.5) direction = new Vector3(direction.x, 1, 0);
                    if (transform.position.x > 5.5) direction = new Vector3(-1, direction.y, 0);
                    else if (transform.position.x < -5.5) direction = new Vector3(1, direction.y, 0);
                }
            }
            else
            {
                if (!startSecondMove) 
                {
                    direction = new Vector3(Random.Range(-1, 2), direction.y, 0);
                    startSecondMove = true;
                }
                if (transform.position.x > 5.5) direction = new Vector3(-1, direction.y, 0);
                else if (transform.position.x < -5.5) direction = new Vector3(1, direction.y, 0);
            }
        }
        return direction;
    }
    public virtual bool CanAttack() 
    {
        if (attackEnable)
        {
            if (signal)
            {
                if (currentAttakingTime < attackTime) currentAttakingTime += Time.deltaTime;
                else
                {
                    currentAttakingTime = 0;
                    signal = false;
                }
            }
            else
            {
                if (currentNonAttakingTime < nonAttackTime) currentNonAttakingTime += Time.deltaTime;
                else
                {
                    currentNonAttakingTime = 0;
                    signal = true;
                }
            }
            return signal;
        }
        else return false;
    }
}
