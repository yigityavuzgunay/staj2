using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float moveSpeed = 1f;

    bool facingRight = true;

    void awake()
    {

    }

    void start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    void update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed PlayerRB.velocity.y);

        if (playerRB.velocity.x > 0 &&)
        {
            //yüzünü çevir
        }
        else if (playerRB.velocity.x > 0 &&)
        {

        }
    