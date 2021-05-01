using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockadeMovement : MonoBehaviour
{
    private BallMovement playerCtrl;
    private Animator movingBlockade;
    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<BallMovement>();
        movingBlockade = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCtrl.gameOver == true)
        {
            movingBlockade.GetComponent<Animator>().enabled = false; ;
            
        }
    }
}
