using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void Start()
    {
        //Invoke("Die", 5);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}