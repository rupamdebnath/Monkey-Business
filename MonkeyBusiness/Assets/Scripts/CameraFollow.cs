using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;

    private bool followPlayer;

    private float YThreshold = -2.6f;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        if(target.position.y < (transform.position.y - YThreshold))
        {
            followPlayer = false;
        }
        if (target.position.y > transform.position.y)
        {
            followPlayer = true;
        }
        if(followPlayer)
        {
            Vector3 temp = transform.position;
            temp.y = target.position.y;
            transform.position = temp;
        }
    }
}
