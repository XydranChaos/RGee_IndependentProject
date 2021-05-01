using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    public float speed;
    public bool gameOver = false;

    public ParticleSystem hitExp;
    public ParticleSystem windSystem;


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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bowling Pins") || collision.gameObject.CompareTag("Blockade") || collision.gameObject.CompareTag("Gutter"))
        {
            Debug.Log("Game Over!");
            gameOver = true;
            hitExp.Play();
            windSystem.Stop();
        }

    }
}
