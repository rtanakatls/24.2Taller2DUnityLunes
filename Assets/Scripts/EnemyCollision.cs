using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private LifeController lifeController;

    private void Awake()
    {
        lifeController = GetComponent<LifeController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            lifeController.ChangeLife(-collision.gameObject.GetComponent<DamageController>().Damage);
        }
    }
}
