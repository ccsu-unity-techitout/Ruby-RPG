using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float timer;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = 3.0f;
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //we also add a debug log to know what the projectile touch
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) { 
            Destroy(gameObject);
        }
    }
}
