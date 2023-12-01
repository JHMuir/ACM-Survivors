using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : WeaponController
{
    //public GameObject hitbox;

    //Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnShield = Instantiate(weaponPrefab);
        //hitbox = Instantiate(hitbox);

        spawnShield.transform.position = transform.position;
        //hitbox.transform.position = transform.position;
        spawnShield.transform.parent = transform;
        //hitbox.transform.parent = transform;
    }
}
