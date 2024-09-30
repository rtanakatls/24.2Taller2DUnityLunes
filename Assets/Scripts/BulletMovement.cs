using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;
    private Vector2 direction;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    private void Move()
    {
        rb2d.velocity = direction.normalized * speed;
    }
}
