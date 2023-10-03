using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 75.0f;
    private Rigidbody2D rb;
    float xMove;
    float yMove;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
    }
 
        private void FixedUpdate()
    {
        rb.velocity = new Vector2(xMove,yMove) * (speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //Debug.Log("Collided with: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            gameManager.AddScore();
        }
    }
}

