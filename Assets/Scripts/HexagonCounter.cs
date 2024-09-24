using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonCounter : MonoBehaviour
{

    [SerializeField] private int counter;

    public void IncreaseCounter()
    {
        counter++;
    }
}
