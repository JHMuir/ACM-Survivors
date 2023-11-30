using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//base class for all weapons to inherit from 
public class WeaponController : MonoBehaviour
{
    [Header("Weapon Settings:")]
    [Space]
    public GameObject weaponPrefab;
    public float damage;
    public float speed;
    public float cooldown;
    float currCooldown;

    protected PlayerMovement player;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        currCooldown = cooldown;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currCooldown -= Time.deltaTime;
        if(currCooldown <= 0) Attack();
        
        
    }

    protected virtual void Attack()
    {
        currCooldown = cooldown;
    }
}
