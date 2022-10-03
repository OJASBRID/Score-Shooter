
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera fpscam;
    Renderer rend;
    Renderer rendr;
    Renderer rendb;
    
    public int score;
    public GameObject red;
    public GameObject blue;
    public ColourChange cls;

    private void Start()
    {
         rendr = red.GetComponent<Renderer>();
         rendb = blue.GetComponent<Renderer>();
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    public void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position,fpscam.transform.forward, out hit))
        {
            rend = hit.transform.GetComponent<Renderer>();
            Debug.Log(rend.sharedMaterial);
            if (rend.sharedMaterial == rendr.sharedMaterial )
            {
                
                score += 10;
                cls.rechange();
                cls.colorchange();

            }

            else if(rend.sharedMaterial == rendb.sharedMaterial)
            {
                score -= 5;
            }
            
        }
    }
}
