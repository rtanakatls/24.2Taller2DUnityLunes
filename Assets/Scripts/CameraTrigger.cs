using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] private int inCameraId;
    [SerializeField] private int outCameraId;

    public int InCameraId {  get { return inCameraId; } }
    public int OutCameraId { get { return outCameraId; } }

}
