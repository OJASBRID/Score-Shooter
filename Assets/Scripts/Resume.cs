using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{   
    public Canvas canvas;
    public Canvas canvas1;
    public void button3()
    {
        canvas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        canvas1.gameObject.SetActive(true);
        Time.timeScale = 1f;
    }
}
