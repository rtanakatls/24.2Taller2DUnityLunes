using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogUIController : MonoBehaviour
{
    [SerializeField] private List<string> dialogTextList;
    private TextMeshProUGUI dialogText;

    private void Awake()
    {
        dialogText=GetComponent<TextMeshProUGUI>();
        StartCoroutine(ShowDialog());
    }

    IEnumerator ShowDialog()
    {
        int i = 0;
        while (i < dialogTextList.Count)
        {
            dialogText.text += $"{dialogTextList[i]}\n";
            yield return new WaitForSeconds(3);
            i++;
        }

    }

}
