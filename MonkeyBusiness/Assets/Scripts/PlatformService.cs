using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformService : MonoBehaviour
{
    public static PlatformService instance;

    [SerializeField]
    private GameObject leftPlatform, rightPlatform;

    private float left_x_min = -4.4f, left_x_max = -2.8f, right_x_min = 4.4f, right_x_max = 2.8f;

    private float y_threshold = 2.6f, last_y;

    public int spawnCount;

    private int platform_spawned;

    [SerializeField]
    private Transform parentPlatform;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        last_y = transform.position.y;
        SpawnPlatforms();
    }

    public void SpawnPlatforms()
    {
        Vector2 temp = transform.position;
        GameObject newPlatform = null;

        for(int i = 0; i < spawnCount; i++)
        {
            temp.y = last_y;

            if((platform_spawned % 2) == 0)
            {
                temp.x = Random.Range(left_x_min, left_x_max);

                newPlatform = Instantiate(rightPlatform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(right_x_min, right_x_max);
                newPlatform = Instantiate(leftPlatform, temp, Quaternion.identity);
            }
            newPlatform.transform.parent = parentPlatform;

            last_y += y_threshold;
            platform_spawned++;
        }
    }
}
