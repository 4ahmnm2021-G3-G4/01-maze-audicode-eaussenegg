using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectTwo : MonoBehaviour
{
   public bool coinTwoEnt = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin2")
        {
            coinTwoEnt = true;
        }
        else
        {

        }
    }
}
