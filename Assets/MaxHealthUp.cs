using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxHealthUp : MonoBehaviour
{
    PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        playerHealth.maxHealth += 2;
    }

    
}
