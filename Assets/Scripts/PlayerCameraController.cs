using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private List<CinemachineVirtualCamera> cameras;

    private void ChangeCamera(int id)
    {
        foreach(CinemachineVirtualCamera cam in cameras)
        {
            cam.Priority = 0;
        }

        cameras[id].Priority = 1;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CameraTrigger"))
        {
            ChangeCamera(collision.gameObject.GetComponent<CameraTrigger>().InCameraId);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CameraTrigger"))
        {
            ChangeCamera(collision.gameObject.GetComponent<CameraTrigger>().OutCameraId);
        }
    }
}
