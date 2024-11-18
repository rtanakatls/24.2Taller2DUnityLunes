using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    [SerializeField] private float maxDistance;
    [SerializeField] private float speed; 
    private float t;

    private void Awake()
    {
        t = 0;
    }

    private void Update()
    {
        t += Time.deltaTime*speed;

        transform.position = new Vector3(Mathf.PingPong(t, maxDistance), 2);
    }

}
