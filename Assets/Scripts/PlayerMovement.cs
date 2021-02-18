using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // adds a public value for movement speed
    public float movementSpeedX;
    // adds a public value for jump strength which impacts jump hight.
    public float jumpStrength = 20f;
    public Transform feet1;
    public Transform feet2;
    public Transform feet3;
    public Transform feet4;
    public LayerMask groundLayers;
    public AudioSource audiosource;
    public AudioClip audioclip;
    public float volume = 0.5f;
    // imports the rigidbody controller from unity itself to be used later on.
    public Rigidbody2D rb;
    // creates a float titled mx or movement x
    float mx;
    static public bool groundCheck = false;
    private void Update() {
        // imports the controls for the horizontal axis, a and d to the float mx
        mx = Input.GetAxis("Horizontal");

        if  (Input.GetButtonDown("Jump") && isGrounded())
        {
            Jump();
        }
        if (isGrounded()){
            groundCheck = true;
        }  else {
            groundCheck = false;
        }
    }
    private void FixedUpdate() {
        // creates a new vector to control horizontal speed, which is equal to movement x times movement speed x. 
        Vector2 movement = new Vector2(mx * movementSpeedX, rb.velocity.y);
        // makes the velocity in the rigidbody2d initialized earlier equal to the movementx vector.
        rb.velocity = movement;
    }
    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpStrength);
            rb.velocity = movement;
            if(Complete.done == false) {
                audiosource.PlayOneShot(audioclip);
            }
    }
        public bool isGrounded ()
    {
        Collider2D groundCheck1 = Physics2D.OverlapCircle(feet1.position, 0.25f, groundLayers);
        Collider2D groundCheck2 = Physics2D.OverlapCircle(feet2.position, 0.25f, groundLayers);
        Collider2D groundCheck3 = Physics2D.OverlapCircle(feet3.position, 0.25f, groundLayers);
        Collider2D groundCheck4 = Physics2D.OverlapCircle(feet4.position, 0.25f, groundLayers);

        if (groundCheck1 != null)
        {
            return true;
        }
        if (groundCheck2 != null)
        {
            return true;
        }
        if (groundCheck3 != null)
        {
            return true;
        }
        if (groundCheck4 != null)
        {
            return true;
        }

        return false;
    }
}

