using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCollision : MonoBehaviour
{
    public MoveForward movement;
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Fake Bowling Pins")
        {
            Debug.Log("Hit Fake Pins!");
            Destroy(gameObject);

        }

    }
}
