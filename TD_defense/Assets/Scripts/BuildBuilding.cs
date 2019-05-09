using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuildBuilding : MonoBehaviour
{
    Build build = new Build();
    UI ui;

    public float PosX;
    public float PosY;
    public float PosZ;

    public bool PlaneCanvas = false;
    
   
    
    public GameObject plane;

    public void Start()
    {
        GameObject camera = new GameObject();
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        ui = camera.GetComponent<UI>();

    
    }

    IEnumerator Delay()
    {
        
        yield return new WaitForSeconds(0.1f);
        ui.BuildNode.SetActive(false);
        PlaneCanvas = false;

    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhinfo;
            
            float raylenght = Mathf.Infinity;
            bool didHit = Physics.Raycast(toMouse, out rhinfo, raylenght);
            

            if (didHit)
            {
                
                
                if (rhinfo.collider.name == "Plane")
                {
                     plane = rhinfo.collider.gameObject;
                     PosX = plane.transform.position.x;
                     PosY = plane.transform.position.y;
                     PosZ = plane.transform.position.z;

                    ui.BuildNode.transform.position = new Vector3(PosX, PosY, PosZ);
                    ui.BuildNode.SetActive(true);

                    PlaneCanvas = true;


                                      
                }
                else if (PlaneCanvas)
                {
                   StartCoroutine(Delay());
                    
                }

               
                
            }
            

        }
    }

}









