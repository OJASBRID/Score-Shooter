using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    
    public Transform orientation;
    public float sensex;
    public float sensey;
    float xrotation;
    float yrotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    void Update()
    {

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensex;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensey;

        yrotation += mouseX;
        xrotation -= mouseY;

        xrotation = Mathf.Clamp(xrotation,-90f,90f);

        transform.rotation = Quaternion.Euler(xrotation,yrotation,0);
        orientation.rotation = Quaternion.Euler(0,yrotation,0);


        
    }
}
