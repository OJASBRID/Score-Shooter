using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public float time = 120f;
    public Shooting shooter;
    public static int Skore;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            Skore = shooter.score;
            SceneManager.LoadScene("Endpage");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}
