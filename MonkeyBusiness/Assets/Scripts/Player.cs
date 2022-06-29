using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D playerBody;

    public float moveSpeed;
    public float normalPush = 10f;
    public float extraPush = 14f;

    private bool initialPush;
    private int pushCount;
    private bool playerDied = false;

    void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (playerDied)
            return;
        Move();
    }

    private void Move()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            playerBody.velocity = new Vector2(moveSpeed, playerBody.velocity.y);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerBody.velocity = new Vector2(-moveSpeed, playerBody.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (playerDied)
            return;
        if (target.tag == "Extrapush")
        {
            if(!initialPush)
            {
                initialPush = true;
                playerBody.velocity = new Vector2(playerBody.velocity.x, 18f);
                target.gameObject.SetActive(false);
                return;
            }
        }
        if(target.tag == "Normalpush")
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, normalPush);
            target.gameObject.SetActive(false);
            pushCount++;
        }

        if (target.tag == "Extrapush")
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, extraPush);
            target.gameObject.SetActive(false);
            pushCount++;
        }
        if(target.tag == "FallBound" || target.tag == "Enemy")
        {
            playerDied = true;
            GameManager.instance.PlayerDeath();
        }
        if(pushCount == 2)
        {
            pushCount = 0;
            PlatformService.instance.SpawnPlatforms();
        }
    }
}
