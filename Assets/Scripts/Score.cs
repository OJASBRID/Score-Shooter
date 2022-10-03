using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
    public Shooting shooter;
    public Text text;
    private void Start()
    {
        text.text = "Score : " + (int)shooter.score;

    }
    void Update()
    {
        
        text.text = "Score : " + (int)shooter.score;
    }
}
