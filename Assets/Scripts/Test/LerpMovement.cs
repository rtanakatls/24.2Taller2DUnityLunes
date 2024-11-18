using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    [SerializeField] private float initialValue;
    [SerializeField] private float targetValue;
    [SerializeField] private float speed;
    private float t;


    private void Awake()
    {
        t = 0;
    }

    private void Update()
    {
        t += Time.deltaTime * speed;

        transform.position = new Vector3(Mathf.Lerp(initialValue, targetValue, t), 4, 0);
    }

}
