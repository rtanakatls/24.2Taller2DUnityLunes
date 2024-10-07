using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightController : MonoBehaviour
{
    private Light2D light2D;
    private float timer;
    [SerializeField] private float lightChangeDelay;
    private float speedFactor;
    

    private void Awake()
    {
        speedFactor = 1;
        light2D = GetComponent<Light2D>();
    }

    private void Update()
    {
        ApplyEffect();
    }

    private void ApplyEffect()
    {
        timer += Time.deltaTime;
        if(timer>=lightChangeDelay)
        {
            speedFactor *= -1;
            timer = 0;
        }

        light2D.pointLightOuterRadius += Time.deltaTime*speedFactor;
    }

}
