using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GutterCollision : MonoBehaviour
{
    public BallMovement movement;
    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Gutter")
        {
            movement.enabled = false;


        }

    }
}
