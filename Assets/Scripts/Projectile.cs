using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Start() {
        //start at player position
        transform.position = GameObject.Find("Player").transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //move right
        transform.Translate(Vector3.right * Time.deltaTime * 10);
        //destroy after 2 seconds
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
