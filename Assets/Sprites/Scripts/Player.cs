using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Searches the same GameObject this script is attached to and returns the Rigidbody2D component if it exists. "rb" now points to that Rigidbody2D.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f); //Keeps horizontal speed the same and forces vertical speed to be zero. "rb.velocity" is a Vector2 that represents objects current motion. "rb.velocity.x" retreives the current horizontal speed. We intentionally keep this. "new Vector2(rb.velocity.x, 0f)" creates a brand new velocity vector that says the horizontal speed (velocity.x) is unchanged and the vertical speed = 0. This overwrites the old velocity. Useful for jumping without freezing in place.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //"ForceMode2D.Impulse" applies force instantly, changes velocity immediately, and is a one-time event. "Vector2.up * jumpForce" is direction times magnitude where "Vector2.up" is the direction and "jumpForce" is the magnitude.
        isGrounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
