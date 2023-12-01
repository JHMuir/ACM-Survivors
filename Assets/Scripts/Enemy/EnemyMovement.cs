using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject target;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        speed = Random.Range(1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }


}
