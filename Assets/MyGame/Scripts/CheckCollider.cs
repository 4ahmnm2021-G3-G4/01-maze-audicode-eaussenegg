using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    // Gate Closing Animation when Entering the Maze.
    public Animator animDoor;
    public bool entered = false;

    // Checking the Coins Entering the Robin Colliders.
    public CoinCollectOne ccOne;
    public CoinCollectTwo ccTwo;
    public CoinCollectThree ccThree;
    public EmblemCollect emCol;
    public bool robinActOne;
    public bool robinActTwo;
    public bool robinActThree;
    public bool robinActFour;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Gate0")
        {
            animDoor.SetBool("EnteringMaze", true);
            entered = true;
        }
        if(other.tag == "Robin-01")
        {
            if(ccOne.coinOneEnt == true)
            {
                robinActOne = true;
            }
        }
        if(other.tag == "Robin-02")
        {
            if (ccTwo.coinTwoEnt == true)
            {
                robinActTwo = true;
            }
        }
        if(other.tag == "Robin-03")
        {
            if(ccThree.coinThreeEnt == true)
            {
                robinActThree = true;
            }
        }
        if (other.tag == "Robin4")
        {
            if (emCol.emblemEnter == true)
            {
                robinActFour = true;
            }
        }
    }
}
