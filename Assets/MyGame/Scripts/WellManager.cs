using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellManager : MonoBehaviour
{
    public int coincounter = 0;
    public bool coinone = false;
    public bool coindue = false;
    public bool cointre = false;
    public bool spawn = false;
    public bool spawnSecondCoin = false;
    public bool spawnTherredCoin = false;

    public GameObject spawnObj;
    public GameObject spawnCoinTwo;
    public GameObject spawnCoinThree;

    public Transform spawnPos;
    public Transform spawnCoin2;
    public Transform spawnCoin3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin1" && coincounter == 0)
        {
            coincounter++;
            coinone = true;
        }
        if(other.tag == "Coin2" && coinone == true && coincounter == 1)
        {
            coincounter++;
            coindue = true;
        }
        if(other.tag == "Coin3" && coinone == true && coindue == true && coincounter == 2)
        {
            coincounter++;
            cointre = true;
        }
        if(coincounter == 3)
        {
            spawn = true;
            SpawnShovel();
        }
        if(coincounter == 1 && spawnSecondCoin == false)
        {
            SpawnSecondCoin();
            spawnSecondCoin = true;
        }
        if(coincounter == 2 && spawnTherredCoin == false)
        {
            SpawnTherredCoin();
            spawnTherredCoin = true;
        }
    }

    private void SpawnShovel()
    {
        if (spawn == true)
        {
            Instantiate(spawnObj, spawnPos.transform.position, spawnPos.transform.rotation);
        }
    }
    private void SpawnSecondCoin()
    {
        Instantiate(spawnCoinTwo, spawnCoin2.transform.position, spawnCoin2.transform.rotation);
    }
    private void SpawnTherredCoin()
    {
        Instantiate(spawnCoinThree, spawnCoin3.transform.position, spawnCoin3.transform.rotation);
    }
}
