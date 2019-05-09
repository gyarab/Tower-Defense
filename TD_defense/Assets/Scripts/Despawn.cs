using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public Spawn spawn;
    private UI ui;

    private void Start()
    {
        GameObject camera = new GameObject();
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        ui = camera.GetComponent<UI>();
        spawn = GetComponentInParent<Spawn>();
    }

    public void OnTriggerEnter(Collider enemy)
    {
        Destroy(enemy.gameObject);
        ui.Lives--;
        spawn.currentUnits--;
        
       
    }
    


}
