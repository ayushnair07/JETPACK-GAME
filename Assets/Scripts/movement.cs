using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField]
    private float movespeed = 3f;
    public GameObject particle;
    public float trackarea;
    public float distfrombul;
    public Transform GOLI;

    [SerializeField]
    private float jetjumpforce = 2f;

  
    
    [SerializeField]
    private float boxHeight;

    [SerializeField]
    private float boxLength;

    [SerializeField]
    private Transform groundPosition;

    [SerializeField]
    private LayerMask groundLayer;

    private Collider2D[] isGrounded = new Collider2D[1];

    private new Rigidbody2D rigidbody;
    private float moveinput;
    private bool isFlying = false;
   
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveinput = Input.GetAxis("Horizontal");
        isFlying = Input.GetKey(KeyCode.W);
       /* float distfromplayer = Vector2.Distance(GOLI.position, transform.position);
        if (distfromplayer < distfrombul)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                Destroy(GOLI);
            }
               
        }*/
    }
    
    void FixedUpdate()
    {
        isGrounded[0] = null;
        Physics2D.OverlapBoxNonAlloc(groundPosition.position, new Vector2(boxLength, boxHeight),0, isGrounded, groundLayer);
        if (isGrounded[0]&&!isFlying )
        {
            
            rigidbody.velocity = new Vector2(moveinput * movespeed, rigidbody.velocity.y);
            rigidbody.freezeRotation = true;
            particle.SetActive(false);
            
            
        }
        else if(isFlying)
        {
            particle.SetActive(true);
            GetComponentInChildren<ParticleSystem>().Play();
            Vector3 rotation = new Vector3(0, 0,-moveinput*3f);
            transform.Rotate(rotation);
            rigidbody.freezeRotation=true;
            rigidbody.AddForce(transform.rotation* Vector2.up * jetjumpforce);
        }
    }
    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(groundPosition.position,new Vector2 (boxLength,boxHeight));
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distfrombul);
    }
    
    
    
}
