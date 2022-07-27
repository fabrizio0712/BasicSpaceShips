using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    [SerializeField] private string objective;
    [SerializeField] private float damage;
    private float currentLifeTime;
    private float speed;
    private Vector2 dir;
    private Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x) > 6.5) Destroy(gameObject);
        if(Mathf.Abs(transform.position.y) > 5) Destroy(gameObject);
        if (currentLifeTime < lifeTime)
        {
            currentLifeTime += Time.deltaTime;
        }
        else Destroy(gameObject);
        rb.velocity = dir * speed;
    }
    public void SetStats(float _speed, Vector2 _dir) 
    {
        speed = _speed;
        dir = _dir;
        currentLifeTime = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == objective) 
        {
            collision.gameObject.GetComponent<Actor>().GetDamage(damage);
            Destroy(this.gameObject);
        }
    }

}
