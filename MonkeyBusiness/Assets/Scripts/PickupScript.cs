using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    [SerializeField]
    private GameObject smallBanana, bigBanana;

    [SerializeField]
    private Transform spawnPoint;

    void Start()
    {
        GameObject newBanana = null;

        if(Random.Range(0,10) > 3)
        {
            newBanana = Instantiate(smallBanana, spawnPoint.position, Quaternion.identity);
        }
        else
        {
            newBanana = Instantiate(bigBanana, spawnPoint.position, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
