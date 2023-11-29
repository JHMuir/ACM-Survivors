using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 25f;
    float x, y;
    [HideInInspector]
    public Vector3 move;

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        // Move the player with normalization
        move = new Vector3(x, y, 0).normalized;
        transform.position += move * speed * Time.deltaTime;


    }


}
