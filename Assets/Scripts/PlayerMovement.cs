using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    [SerializeField] private float boostFactor;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(horizontal, vertical).normalized * speed * boostFactor;
        }
        else
        {
            rb2d.velocity = new Vector2(horizontal, vertical).normalized * speed;
        }
    }
}
