using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUps : MonoBehaviour
{
    public GameObject powerUpPrefab;
    private float spawnRange = 4.0f;
    // Start is called before the first frame update
    private int powerUpNumber = 1;
    void Start()
    {
        SpawnPickUpItem(powerUpNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPickUpItem(int pickUpNum)
    {
        for(int i = 0; i < pickUpNum; i++ )
        {
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRange, spawnRange);
        float zPos = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(xPos, powerUpPrefab.transform.position.y, zPos);
        return spawnPos;
    }
}
