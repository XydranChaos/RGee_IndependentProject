using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    public float speed;
    public bool gameOver = false;
    public bool hasPowerUp = false;

    public GameObject powerUpInd;

    public ParticleSystem hitExp;
    public ParticleSystem windSystem;

    private GameManager gameManager;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float ballHorizontal = Input.GetAxis("Horizontal");
        float ballVertical = Input.GetAxis("Vertical");

        Vector3 ballMovement = new Vector3(ballHorizontal, 0.0f, ballVertical);

        rigidBody.AddForce(ballMovement * speed);

        powerUpInd.transform.position = transform.position;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bowling Pins") || collision.gameObject.CompareTag("Blockade") || collision.gameObject.CompareTag("Gutter"))
        {
            gameManager.GameOver();
            gameOver = true;
            hitExp.Play();
            windSystem.Stop();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            speed = 50;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdown());
            powerUpInd.SetActive(true);
        }
    }
    
    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(4);
        hasPowerUp = false;
        powerUpInd.SetActive(false);
        speed = 15;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("RGee_IndependentProject");
    }
}
