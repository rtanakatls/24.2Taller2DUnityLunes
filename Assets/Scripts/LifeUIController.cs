using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeUIController : MonoBehaviour
{
    private static LifeUIController instance;

    public static LifeUIController Instance {  get { return instance; } }

    [SerializeField] private Image lifeBar;

    private void Awake()
    {
        instance = this;
    }

    public void SetLifeBar(float value,float maxValue)
    {
        lifeBar.fillAmount = value / maxValue;
    }
}
