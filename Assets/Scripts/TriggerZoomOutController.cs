using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{

    public Collider bola;   
    public CameraController cameraController;

 
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
