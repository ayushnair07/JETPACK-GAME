using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GameObject target;
    public float speed;
    public Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedr=(target.transform.position - transform.position).normalized*speed;
        rb.velocity=new Vector2(movedr.x,movedr.y);
        
    }
    

}
