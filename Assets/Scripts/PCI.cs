using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCI : PlayerControl
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