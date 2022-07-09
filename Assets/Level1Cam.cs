using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Cam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    private void Update()
    {
        if (transform.position.y >-5f)
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
            cam3.SetActive(false);
        }
        if (transform.position.y<-5f && transform.position.y > -15f)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
            cam3.SetActive(false);
        }
        if(transform.position.y<-15f)
        {
            cam2.SetActive(false);
            cam1.SetActive(false);
            cam3.SetActive(true);
        }
       
    }
}
