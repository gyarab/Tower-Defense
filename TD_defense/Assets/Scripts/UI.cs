using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private GameObject precanvas;
    private GameObject text;
    
    

    private void Start()
    {
        precanvas = new GameObject();
        text = new GameObject();
        


        //vygeneruje canvas do ktereho se dava UI
        precanvas.name = "canvas";
        precanvas.AddComponent<Canvas>();
        Canvas canvas = precanvas.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = GetComponent<Camera>();

        



        //nastaveni textu
        text.name = "text";
        text.transform.parent = precanvas.transform;
        text.AddComponent<RectTransform>();
        text.AddComponent<Text>();


    

        // nacte velikost objektu
        RectTransform CanvasSize = precanvas.GetComponent<RectTransform>();
        RectTransform TextSize = text.GetComponent<RectTransform>();

        //nastaveni velikosti rohu
        TextSize.anchoredPosition3D = new Vector3(0f, 0f, 0f);
        TextSize.sizeDelta = new Vector2(0f, 0f);
        TextSize.anchorMin = new Vector2(0f, 0f);
        TextSize.anchorMax = new Vector2(1f, 1f);

        // nastaveni fontu
        Text textComponent = text.GetComponent<Text>();
        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        textComponent.font = ArialFont;
       
        // nastaveni textu
        textComponent.text = "Hello World";


    }

}
