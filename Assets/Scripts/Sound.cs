using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource pinSound;
    public bool playedSound = false;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //checking if the sound was played and comparing the player tag if it has collided
        if (playedSound == false && other.gameObject.CompareTag("Player"))
        {
            //if the sound hasn't been played, when hitting the bowling pins trigger, it will play
            //the sound effect & if it's already been played, the audio will not play again when
            //the ball collides with the pins after the first time.
            playedSound = true;
            pinSound.Play();
        }
        else if(other.gameObject.CompareTag("Ball"))
        {
            pinSound.Play();
        }
    }
}