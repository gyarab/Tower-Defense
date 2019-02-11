using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{   
    public GameObject [] buildings;
    private BuildingPlacement buildingPlacement;



    private void Start()
    {
        buildingPlacement = GetComponent<BuildingPlacement>();
    }





      void BuildTower()
    {
        
            for (int i = 0; i < buildings.Length; i++)
            {
                if (GUI.Button(new Rect(Screen.width/20, Screen.height/15 + Screen.height/12 * i, 100, 30), buildings[i].name))
                {
                buildingPlacement.SetItem(buildings[i]);
                }
            }
            
        
    }

        
}
