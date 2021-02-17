using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 5F;

    private Vector3 moveVelocity;
    [SerializeField]
    protected  Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput * speed;
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + moveVelocity * Time.deltaTime;
        //rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
    }


}


