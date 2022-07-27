using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterInput))]
public class Character : Actor
{
    [SerializeField] private GameObject bullet;
    private CharacterInput charInput;

    private void Awake()
    {
        charInput = gameObject.GetComponent<CharacterInput>();
        controller = gameObject.GetComponent<Controller>();
        currentDir = Vector2.zero;
        currentLife = stats.Life;
        currentSpeed = stats.Speed;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (charInput.IsPressingForward && !charInput.IsPressingBackward && transform.position.y < 4.5) currentDir.y = 1;
        else if (!charInput.IsPressingForward && charInput.IsPressingBackward && transform.position.y > -4.5) currentDir.y = -1;
        else currentDir.y = 0;
        if (charInput.IsPressingRight && !charInput.IsPressingLeft && transform.position.x < 6) currentDir.x = 1;
        else if (!charInput.IsPressingRight && charInput.IsPressingLeft && transform.position.x > -6) currentDir.x = -1;
        else currentDir.x = 0;
        if (charInput.IsPressingShoot) controller.Attack(weapon, new Vector2(0,1), bullet, transform);
        controller.Move(currentDir, currentSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            GetDamage(currentLife);
        }
    }
}
