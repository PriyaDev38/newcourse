using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowmoment : MonoBehaviour
{
    Rigidbody2D playerRb;
    public float playerSpeed = 5f;
    Animator playerAnimation;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        playerRb.velocity = playerMovement * playerSpeed;

        if (playerRb.velocity.y > 0)
        {
            playerAnimation.SetInteger("Switchany", 1);
            
        }
        else
        {
            playerAnimation.SetInteger("Switchany", 0);
        }
    }
}
