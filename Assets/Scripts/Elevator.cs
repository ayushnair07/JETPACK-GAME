using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform UpPos;
    public Transform DownPos;

    public GameObject Player;

    public float speed=10f;

    bool isElevatorUp;


    private void Update()
    {
        if (Vector2.Distance(transform.position, Player.transform.position) < 2f && Input.GetKeyDown("e"))
        {
            if (transform.position.y > DownPos.position.y)
            {
                isElevatorUp = true;
            }
            else if (transform.position.y <= UpPos.position.y)
            {
                isElevatorUp = false;
            }
        }

        if (isElevatorUp)
        {
            transform.position = Vector2.MoveTowards(transform.position, DownPos.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, UpPos.position, speed * Time.deltaTime);
        }
    }
    
}
