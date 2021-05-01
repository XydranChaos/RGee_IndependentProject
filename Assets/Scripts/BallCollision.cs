using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public BallMovement movement;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bowling Pins")
        {
            movement.enabled = false;
            Score.scoreAmount += 100;


        }
        if (collision.collider.tag == "Blockade")
        {
            movement.enabled = false;

        }

    }
}