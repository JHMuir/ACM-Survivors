using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehavior : ProjectileBehavior
{
    //this script is applied to the prefab 
    KnifeController knifeController;
    
    protected override void Start()
    {
        base.Start();
        knifeController = FindObjectOfType<KnifeController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * knifeController.speed * Time.deltaTime;
    }
}
