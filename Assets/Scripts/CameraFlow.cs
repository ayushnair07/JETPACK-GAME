using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    [SerializeField] private Transform target = null;
    private Vector3 offset;         
    void Start()
    {
        offset=transform.position-target.position;  

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position=Vector3.Lerp(transform.position,new Vector3(target.position.x,0,0)+offset,Time.deltaTime*3);
    }
}
