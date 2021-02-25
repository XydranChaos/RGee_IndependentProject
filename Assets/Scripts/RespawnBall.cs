using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public BallMovement movement;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        movement.enabled = true;
    }
}