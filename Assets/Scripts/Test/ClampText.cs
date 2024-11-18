using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClampText : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float timer;


    private void Awake()
    {
        timer = 0;
        timerText= GetComponent<TextMeshProUGUI>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer++;
        }
        timer -= Time.deltaTime;

        timer = Mathf.Clamp(timer, 0, 10);

        

        timerText.text = $"Timer: {Mathf.Ceil(timer)}\n";
        timerText.text += $"Timer: {Mathf.Floor(timer)}\n";
        timerText.text += $"Timer: {Mathf.Round(timer)}\n";
    }

}
