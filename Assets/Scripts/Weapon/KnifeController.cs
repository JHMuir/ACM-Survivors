using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class KnifeController : WeaponController //inherits from 
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();

        //spawns two knives, one in front and and one behind the player
        GameObject spawnKnife1 = Instantiate(weaponPrefab);
        GameObject spawnKnife2 = Instantiate(weaponPrefab);
        spawnKnife1.transform.position = transform.position;
        spawnKnife2.transform.position = transform.position;
        spawnKnife1.GetComponent<KnifeBehavior>().DirectionCheck(player.move);
        spawnKnife2.GetComponent<KnifeBehavior>().DirectionCheck(-player.move);
    }
}
