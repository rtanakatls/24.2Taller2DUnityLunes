using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerLifeController playerLifeController;

    private void Awake()
    {
        playerLifeController=GetComponent<PlayerLifeController>();
    }

    private void TakeDamage(int damage)
    {
        playerLifeController.ChangeLife(-damage);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(collision.gameObject.GetComponent<DamageController>().Damage);
        }
    }
}
