using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool doorStatus;
    [SerializeField] private GameObject doorHandler;
    private bool isPlayerIn;

    private void Update()
    {
        CheckAction();
        MoveDoor();
    }

    private void MoveDoor()
    {
        if (doorStatus)
        {
            doorHandler.transform.eulerAngles += new Vector3(0, 0, 90) * Time.deltaTime;
            if (doorHandler.transform.eulerAngles.z >= 90)
            {
                doorHandler.transform.eulerAngles = new Vector3(0, 0, 90);
            }
        }
        else
        {

            doorHandler.transform.eulerAngles -= new Vector3(0, 0, 90) * Time.deltaTime;
            if (doorHandler.transform.eulerAngles.z <= 0 || doorHandler.transform.eulerAngles.z >=300)
            {
                doorHandler.transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
    }

    private void CheckAction()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerIn)
        {
            doorStatus = !doorStatus;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerIn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerIn = false;
        }
    }
}
