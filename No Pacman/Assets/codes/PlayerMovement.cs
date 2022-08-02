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
        if(movement.x == -1)
        {
            sp.flipX = true;
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,0);
        }
        else if(movement.x == 1)
        {
            sp.flipX = false;
            sp.gameObject.transform.localRotation = Quaternion.Euler(0,0,0);
        }
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
    
}