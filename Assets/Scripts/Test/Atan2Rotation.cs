using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atan2Rotation : MonoBehaviour
{
    private Camera cam;

    private void Awake()
    {
        cam = GameObject.Find("Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);


        Vector2 direction = mousePosition - transform.position;


        transform.eulerAngles = new Vector3(0,0,Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg);
    }
}
