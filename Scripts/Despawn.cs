﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public Spawn spawn;

    

    public void OnTriggerEnter(Collider enemy)
    { MoveOnPath parent = enemy.GetComponentInParent<MoveOnPath>();
        Destroy(parent.gameObject);
        spawn.currentUnits--;
        
       
    }
    


}
