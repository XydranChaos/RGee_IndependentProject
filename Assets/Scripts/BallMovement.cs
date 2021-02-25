using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    public float speed;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float ballHorizontal = Input.GetAxis("Horizontal");
        float ballVertical = Input.GetAxis("Vertical");

        Vector3 ballMovement = new Vector3(ballHorizontal, 0.0f, ballVertical);

        rigidBody.AddForce(ballMovement * speed);
    }
}
