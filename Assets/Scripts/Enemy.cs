using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float trackarea;
    public Transform player;
    public GameObject Bullet;
    public float firerate = 1f;
    public float nextfire;
    public GameObject Bulletpos;
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Update()
    {
        float distfromplayer = Vector2.Distance(player.position, transform.position);
        if (distfromplayer < trackarea && nextfire<Time.time)
        {
           Instantiate(Bullet,Bulletpos.transform.position,transform.rotation);
            nextfire = Time.time+firerate;
        }
        
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, trackarea);
    }
    
}
