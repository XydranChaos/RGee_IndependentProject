using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPeople : MonoBehaviour
{
    private BallMovement playerCtrl;
    private Animator animPeople;
    void Start()
    {
        playerCtrl = GameObject.Find("Player").GetComponent<BallMovement>();
        animPeople = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCtrl.gameOver == false)
        {
            animPeople.SetTrigger("Jump_trig");
            
        }
        else
        {
            animPeople.SetInteger("Animation_int", 1);
        }
    }
        
}
