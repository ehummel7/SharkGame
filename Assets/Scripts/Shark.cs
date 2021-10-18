using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public float PlayerSpeed = 10;
    public bool facingRight = true;

    public Rigidbody2D rb;
    public float moveX;
    public float moveY;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        //Physics
        rb.velocity = new Vector2(moveX * PlayerSpeed, moveY * PlayerSpeed);
    }
}
