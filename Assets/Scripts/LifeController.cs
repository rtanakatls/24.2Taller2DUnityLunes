using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int life;

    public void ChangeLife(int value)
    {
        life += value;
        if (life <= 0)
        {
            life = 0;
            Destroy(gameObject);
        }
    }
}
