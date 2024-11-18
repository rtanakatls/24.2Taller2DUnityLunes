using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float t;

    private void Awake()
    {
        t = 0;
    }

    private void Update()
    {
        t += Time.deltaTime * speed;

        transform.position = new Vector3(t * 10, Mathf.Sin(t * 360 * Mathf.Deg2Rad)*5, 0);
    }

}
