using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 100.0f;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0.0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
