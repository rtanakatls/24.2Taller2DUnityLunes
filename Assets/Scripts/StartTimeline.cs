using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class StartTimeline : MonoBehaviour
{
    private PlayableDirector playableDirector;

    private void Awake()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }

    public void LoadScene(string sceneName)
    {
        playableDirector.Play();
        StartCoroutine(Playing(sceneName));
        
    }

    IEnumerator Playing(string sceneName)
    {
        while(playableDirector.state==PlayState.Playing)
        {
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }
}
