using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject FBallPrefab;
    public GameObject FBallPrefab2;
    private UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(4, 8, -14);
    private UnityEngine.Vector3 spawnPos2 = new UnityEngine.Vector3(-4, 1, -10);


    void Start()
    {
        InvokeRepeating("SpawnBall", 2, 8);
        InvokeRepeating("SpawnOtherBall", 2, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBall()
    {
        Instantiate(FBallPrefab, spawnPos, FBallPrefab.transform.rotation);
    }
    void SpawnOtherBall()
    {
        Instantiate(FBallPrefab2, spawnPos2, FBallPrefab2.transform.rotation);
    }
}
