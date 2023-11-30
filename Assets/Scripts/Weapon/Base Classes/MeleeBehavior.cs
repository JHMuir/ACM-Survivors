using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBehavior : MonoBehaviour
{
    public float meleeLife;

    protected virtual void Start()
    {
        Destroy(gameObject, meleeLife);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
    
}
