using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectThree : MonoBehaviour
{
    public bool coinThreeEnt = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin3")
        {
            coinThreeEnt = true;
        }
        else
        {

        }
    }
}
