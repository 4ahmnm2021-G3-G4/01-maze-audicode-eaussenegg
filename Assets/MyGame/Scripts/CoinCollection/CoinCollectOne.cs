using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectOne : MonoBehaviour
{
    public bool coinOneEnt = false;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin1")
        {
            coinOneEnt = true;
        }
        else
        {

        }
    }
}
