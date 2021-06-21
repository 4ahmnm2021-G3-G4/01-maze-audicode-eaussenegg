using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeManager : MonoBehaviour
{
    public CheckCollider checkCol;
    public WellManager wM;
    public ExitOpening eO;

    public AudioSource gateSound;
    public AudioSource exitSound;
    public AudioSource coinOne;
    public AudioSource coinTwo;
    public AudioSource coinThree;
    public AudioSource robinOne;
    public AudioSource robinTwo;
    public AudioSource robinThree;
    public AudioSource robinFour;
    public AudioSource kuckuck;

    private GameObject CoinTwo;
    private GameObject CoinThree;

    public void Update()
    {
        if(checkCol.entered == true)
        {
            gateSound.Stop();
            coinOne.mute = false;
            robinOne.mute = false;
        }
        if(checkCol.robinActOne == true)
        {
            robinOne.Stop();
            kuckuck.mute = false;
        }
        if(wM.coinone == true)
        {
            coinOne.Stop();
            robinTwo.mute = false;
            if(wM.coinone == true && checkCol.robinActTwo == false)
            {
                kuckuck.mute = true;
                print("working prop");
            }
        }
        if(checkCol.robinActTwo == true)
        {
            robinTwo.Stop();
            kuckuck.mute = false;
        }
        if(wM.coindue == true)
        {
            coinTwo.Stop();
            robinThree.mute = false;
            if (wM.coindue == true && checkCol.robinActThree == false)
            {
                kuckuck.mute = true;
                print("working prop");
            }
        }
        if (checkCol.robinActThree == true)
        {
            robinThree.Stop();
            kuckuck.mute = false;
        }
        if(wM.cointre == true)
        {
            coinThree.Stop();
            robinFour.mute = false;
            if(wM.coindue == true && checkCol.robinActFour == false)
            {
                kuckuck.mute = true;
            }
        }
        if(checkCol.robinActFour == true)
        {
            robinFour.Stop();
            kuckuck.Stop();
            exitSound.mute = false; 
        }
        if(eO.leavingMaze == true)
        {
            exitSound.Stop();
        }

        SearchForCoins();
    }

    public void SearchForCoins()
    {
        CoinTwo = GameObject.FindGameObjectWithTag("Coin2Sound");
        coinTwo = CoinTwo.GetComponent<AudioSource>();
        CoinThree = GameObject.FindGameObjectWithTag("Coin3Sound");
        coinThree = CoinThree.GetComponent<AudioSource>();
    }
}
