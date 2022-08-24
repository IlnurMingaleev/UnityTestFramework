using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnMouseOver : MonoBehaviour
{
    private Color startcolor;
    private SpriteRenderer renderer;

    void Start() 
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    void OnMouseEnter()
    {
        startcolor = renderer.material.color;
        renderer.material.color = Color.blue;
    }
    void OnMouseExit()
    {
        renderer.material.color = startcolor;
    }
}
