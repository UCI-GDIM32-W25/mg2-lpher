using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float despawnX = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckDespawn();
    }
    private void Move()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
    private void CheckDespawn()
    {
        if (transform.position.x < despawnX)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) //"OnTriggerEnter2D" is basically saying when something enters this object’s trigger collider, call this method and tells us what that something is. "other" is a variable and "Collider2D" is its type. Represents the collider that entered the trigger (the collider that enters the coin in this case). "other" is an object's collider. Not a GameObject. It is the Collider2D component attacted to that object. The "." inbetween the words is basically saying to acces something that belongs to this object. Each dot moves you one level deeper. 
    {
        if (other.CompareTag("Player"))
        {
            ScoreText.Instance.AddPoint();
            Destroy(gameObject);
        }
    }
}
