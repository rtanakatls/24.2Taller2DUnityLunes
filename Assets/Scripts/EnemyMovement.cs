using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    private float timer;
    [SerializeField] private float changeDirectionTime;
    [SerializeField] private Vector2 direction;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ChangeDirection();
        Move();
    }

    private void ChangeDirection()
    {
        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            direction *= -1;
            timer = 0;
        }
    }

    private void Move()
    {
        rb2d.velocity = direction.normalized * speed;
    }
}
