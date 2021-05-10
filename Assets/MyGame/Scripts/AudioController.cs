using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource robin;
    void Start()
    {
        robin = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            robin.Pause();
        }   
        else if(Input.GetKey(KeyCode.P))
        {
            robin.UnPause();
        }
    }
}
