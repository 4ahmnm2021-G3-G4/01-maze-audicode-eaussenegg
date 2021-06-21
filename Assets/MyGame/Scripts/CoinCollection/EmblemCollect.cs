using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmblemCollect : MonoBehaviour
{
    public bool emblemEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Emblem")
        {
            emblemEnter = true;
        }
        else
        {

        }
    }
}
