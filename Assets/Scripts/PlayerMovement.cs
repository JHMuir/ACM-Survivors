using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 25f;
    float x, y;


    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        // Move the player with normalization
        transform.position += new Vector3(x, y, 0).normalized * speed * Time.deltaTime;


    }


}
