using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletUIController : MonoBehaviour
{
    private static BulletUIController instance;

    public static BulletUIController Instance {  get { return instance; } }


    private TextMeshProUGUI bulletText;

    private void Awake()
    {
        instance = this;
        bulletText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(int bullets)
    {
        bulletText.text = $"Bullets: {bullets}";
    }



}
