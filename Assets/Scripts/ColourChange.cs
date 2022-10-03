using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public GameObject[] cube;
    public Material Tr;
    public Material Tb;
    GameObject cubesel;
    GameObject cubenel;
    Renderer rend;
    Renderer rend1;
    public float time;
     float Reftime;
     int lastbox;
    float diff;
    public float x;

    
    private void Start()
    {
        Reftime = time;
        lastbox = 0;
        diff = 5f;
        
    }
    void Update()
    {
        time -= Time.deltaTime;
        if(Reftime - time >diff)
        {
            Reftime -= diff;
            rechange();
            colorchange();
            
            
        }

        
    }

    public void colorchange()
    { if (diff > 1.2f)
        { 
        diff = diff / x;
        }
        lastbox = Random.Range(0, cube.Length);
       cubesel = cube[lastbox];
       rend = cubesel.GetComponent<Renderer>();
        rend.material = Tr;
    }

    public void rechange()
    {
        cubenel = cube[lastbox];
        rend1 = cubenel.GetComponent<Renderer>();
        rend1.material = Tb;
    }
}
