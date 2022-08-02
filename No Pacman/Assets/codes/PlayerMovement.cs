using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rb;
    
    [SerializeField]
    private SpriteRenderer sp;
    Vector2 movement;
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        //Make sure the sprite is facing the right direction in the x-axis
        if(movement.x == -1)
        {
            sp.flipX = true;
            movement.y = 0; //This makes thex-axis take preference over y-axis movement
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,0); //Reset rotation
        }
        else if(movement.x == 1)
        {
            sp.flipX = false;
            movement.y = 0; //This makes thex-axis take preference over y-axis movement
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,0); //Reset rotation
        }
        //Make sure the sprite is facing the right direction in the y-axis
        if(movement.y == -1)
        {
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,90);
            sp.flipX = true;
        }
        else if(movement.y == 1)
        {
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,90);
            sp.flipX = false;
        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        movement = Vector2.zero;
        rb.velocity = Vector2.zero;
    }
}