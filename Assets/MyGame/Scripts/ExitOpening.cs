using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOpening : MonoBehaviour
{
    public GameObject transEmblem;
    public GameObject emblem;
    public Animator exitAnim;
    public bool leavingMaze = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Emblem")
        {
            transEmblem.SetActive(false);
            emblem.SetActive(true);
            leavingMaze = true;
            Destroy(other.gameObject);
            OpeningExit();
        }
    }

    public void OpeningExit()
    {
        exitAnim.SetBool("leaving", true);
    }
}
