using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
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
    void Move()
    {

    transform.Translate(Vector3.down * enemySpeed * Time.deltaTime, Space.World);
    }
}
