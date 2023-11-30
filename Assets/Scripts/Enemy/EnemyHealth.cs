using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        GameObject.Find("ExperienceSystem").GetComponent<ExperienceSystem>().GainExperience(1);
        Destroy(gameObject);
    }
}
