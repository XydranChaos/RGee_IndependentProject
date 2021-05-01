using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject FBallPrefab;
    public GameObject FBallPrefab2;
    private BallMovement playerCtrl;
    private Vector3 spawnPos = new Vector3(4, 8, -14);
    private Vector3 spawnPos2 = new Vector3(-4, 1, -10);


    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<BallMovement>();

            InvokeRepeating("SpawnBall", 2, 8);
            InvokeRepeating("SpawnOtherBall", 2, 8);    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBall()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(FBallPrefab, spawnPos, FBallPrefab.transform.rotation);
        }
    }
    void SpawnOtherBall()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(FBallPrefab2, spawnPos2, FBallPrefab2.transform.rotation);
        }
    }

}
