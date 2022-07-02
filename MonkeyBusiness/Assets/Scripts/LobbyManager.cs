using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    
    public void PlayButton()
    {
        SoundManager.instance.PlaySound(1);
        StartCoroutine(StartGame());
    }
    public void QuitButton()
    {
        SoundManager.instance.PlaySound(1);
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
        SoundManager.instance.PlaySound(0);
    }
}
