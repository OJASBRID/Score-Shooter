using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{

    public Ending ending;
    public Text text;

    private void Start()
    {
        text.text = "Time :" + (int)ending.time;
    }
    void Update()
    {
        text.text = "Time :" + (int)ending.time;
    }
}
