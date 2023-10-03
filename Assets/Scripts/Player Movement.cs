using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 75.0f;
    private Rigidbody2D rb;
    float xMove;
    public GameManager gameManager;
    [SerializeField] private AudioSource scoreSoundEffect;
    [SerializeField] private AudioSource deathSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        
    }
 
        private void FixedUpdate()
    {
        rb.velocity = new Vector2(xMove, 0) * (speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Debug.Log("Collided with: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            scoreSoundEffect.Play();
            Destroy(collision.gameObject);
            gameManager.AddScore();
        }
        if (collision.gameObject.tag == "Death")
        {
            Die();
        }
    }
        private void Die()
        {
            deathSoundEffect.Play();
        }
    }