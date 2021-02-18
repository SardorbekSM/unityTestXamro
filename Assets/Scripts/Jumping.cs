using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : Movement
{
    protected override void Update()
    {
        base.Update();
        if (Input.GetButton("Jump"))
        {
            Jump();
        }
    }

    protected void Jump()
    {
        rb.AddForce(transform.up * 0.09f, ForceMode2D.Impulse);
    }
}