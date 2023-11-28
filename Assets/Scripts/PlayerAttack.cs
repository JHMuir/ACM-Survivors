using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            //Shoot a projectile to the right
            Instantiate(projectile);
            

        }
    }
}
