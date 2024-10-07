using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int maxLife;

    private void Start()
    {
        LifeUIController.Instance.SetLifeBar(life, maxLife);
    }

    public void ChangeLife(int value)
    {
        life += value;
        LifeUIController.Instance.SetLifeBar(life, maxLife);
        if (life <= 0)
        {
            life = 0;
            Destroy(gameObject);
        }
    }
}
