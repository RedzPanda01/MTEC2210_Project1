using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundEffect;
    public float enemySpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            deathSoundEffect.Play();
        Destroy(collision.gameObject);
    }
    void Move()
    {

    transform.Translate(Vector3.down * enemySpeed * Time.deltaTime, Space.World);
    }
}
