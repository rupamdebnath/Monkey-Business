using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour
{
    GameObject[] backgrounds;

    float height;

    float highestYPos;

    private void Awake()
    {
        backgrounds = GameObject.FindGameObjectsWithTag("BG");
    }

    private void Start()
    {
        height = backgrounds[0].GetComponent<BoxCollider2D>().bounds.size.y;
        highestYPos = backgrounds[0].transform.position.y;
    }
}
