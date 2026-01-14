using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 1f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //Jump with SPACE key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * _jumpHeight * Time.deltaTime);
            Debug.Log(transform.position);
        }
    }
}
