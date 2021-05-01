using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawn : MonoBehaviour
{
    public GameObject[] LightPrefabs;
    private float xPosRange = 10;
    private BallMovement playerCtrl;
     
    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<BallMovement>();
        InvokeRepeating("SpawnRandomLights", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCtrl.gameOver == true)
        {
            CancelInvoke("SpawnRandomLights");
        }


    }
    void SpawnRandomLights()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int LightPrefabIndex = Random.Range(0, LightPrefabs.Length);

        Vector3 randPos = new Vector3(randXPos, 1, -5);
        Instantiate(LightPrefabs[LightPrefabIndex], randPos,
               LightPrefabs[LightPrefabIndex].transform.rotation);
    }

}
