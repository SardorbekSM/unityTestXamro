using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool forJump;

    private Vector3 moveVelocity;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput * speed;

        Updated();
    }
    
    // Jump 2th player
    protected virtual void Updated()
    {
        if (Input.GetButton("Jump") && forJump)
        {
            Jump();
        }
    }

    // Function for the Jump player
    private void Jump()
    {
        rb.AddForce(transform.up * 0.09f, ForceMode2D.Impulse);
    }



    private void FixedUpdate()
    {
        transform.position = transform.position + moveVelocity * Time.deltaTime;
        //rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
    }


}

public class PlayerControlJump : PlayerControl
{

}
