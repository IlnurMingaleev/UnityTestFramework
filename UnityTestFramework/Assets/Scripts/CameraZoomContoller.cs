using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomContoller : MonoBehaviour
{
    private Camera cam;
    private float targetZoom;
    public float zoomVector;
    private float zoomLerpSpeed = 10;
    private float scrollData = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ZoomIn() 
    {
        
        targetZoom -= scrollData * zoomVector;
        targetZoom = Mathf.Clamp(targetZoom, 3f, 8f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, zoomLerpSpeed);

    }

    public void ZoomOut() 
    {
        targetZoom += scrollData * zoomVector;
        targetZoom = Mathf.Clamp(targetZoom, 4.5f, 8f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, zoomLerpSpeed);
    }
}
