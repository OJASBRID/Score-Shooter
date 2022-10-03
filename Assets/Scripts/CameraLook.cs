using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    
    public Transform orientation;
    public float sensex;
    public float sensey;
    public Canvas canvas;
    public Canvas canvas1;
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


        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            canvas.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            canvas1.gameObject.SetActive(false);
        }

        
    }
}
