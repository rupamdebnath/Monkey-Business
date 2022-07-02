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

        for(int i = 1; i < backgrounds.Length; i++)
        {
            if(backgrounds[i].transform.position.y > highestYPos)
            {
                highestYPos = backgrounds[i].transform.position.y;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "BG")
        {
            if(target.transform.position.y >= highestYPos)
            {
                Vector3 temp = target.transform.position;
                for(int i = 0; i < backgrounds.Length; i++)
                {
                    if(!backgrounds[i].activeInHierarchy)
                    {
                        temp.y += height;
                        backgrounds[i].transform.position = temp;
                        backgrounds[i].gameObject.SetActive(true);

                        highestYPos = temp.y;
                    }
                }
            }
        }
    }
}
