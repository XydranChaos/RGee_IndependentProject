using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPeople : MonoBehaviour
{
    private BallMovement playerCtrl;
    public GameObject person;
    public bool moving = true;
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
            StartCoroutine(MovingAnimation());
            animPeople.SetTrigger("Jump_trig");  
        }
        else
        {
            animPeople.SetInteger("Animation_int", 1);
            person.SetActive(false);
        }
        
        IEnumerator MovingAnimation()
        {
            yield return new WaitForSeconds(1);
            moving = true;
            person.SetActive(true);

        }
    }

        
}
