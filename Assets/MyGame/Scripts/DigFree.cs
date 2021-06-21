using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigFree : MonoBehaviour
{
    public GameObject dirt0;
    public GameObject dirt1;
    public GameObject dirt2;

    public GameObject emblem;
    public Transform spawnInteractable;
    public GameObject emblemInt;

    public int digcounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shovel")
        {
            digcounter++;
            if(digcounter == 1)
            {
                dirt0.SetActive(false);
                dirt1.SetActive(true);
            }
            if(digcounter == 2)
            {
                dirt1.SetActive(false);
                dirt2.SetActive(true);
            }
            if(digcounter == 3)
            {
                dirt2.SetActive(false);
                emblem.SetActive(false);
                SpawnInteractable();
            }
        }
    }
    private void SpawnInteractable()
    {
        Instantiate(emblemInt, spawnInteractable.transform.position, spawnInteractable.transform.rotation);
    }
}
