using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

//base class for all projectiles to inherit from 
public class ProjectileBehavior : MonoBehaviour
{
    protected Vector3 direction;
    [Header("Projectile Settings:")]
    public float projectileLife;

    protected virtual void Start() {
        //start at player position
        //transform.position = GameObject.Find("Player").transform.position;
        Destroy(gameObject, projectileLife);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            Destroy(gameObject);
        }
    }

    public void DirectionCheck(Vector3 dir)
    {
        direction = dir;
        float x = direction.x;
        float y = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        //the following code moves the rotates/scales the prefab the correct direction based on the player
        //it is gross and ugly but idk how else to do it
        if(x < 0 && y == 0) //left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if (x == 0 && y < 0) //down
        {
            scale.y = scale.y * -1;
        }
        else if (x == 0 && y > 0) //up
        {
            scale.x = scale.x * -1;
        }
        else if (x > 0 && y > 0) //right up
        {
            rotation.z = 0f;
        }
        else if (x > 0 && y < 0) //right down
        {
            rotation.z = -90f;
        }
        else if (x < 0 && y > 0) //left up
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = -90f;
        }
        else if (x < 0 && y < 0) //left down
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = 0f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
