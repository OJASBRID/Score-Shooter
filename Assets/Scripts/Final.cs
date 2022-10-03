using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "Your Score is " + Ending.Skore;
    }

    
}
