using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D playerBody;

    public float moveSpeed = 2f;
    public float normalPush = 10f;
    public float extraPush = 14f;

    private bool initialPush;
    private int pushCount;
    private bool playerDied;

    void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Extrapush")
        {
            if(!initialPush)
            {
                initialPush = true;
                playerBody.velocity = new Vector2(playerBody.velocity.x, 18f);
                target.gameObject.SetActive(false);
            }
        }
    }
}
