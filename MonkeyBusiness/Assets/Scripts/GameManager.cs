using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject DeathMenu;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void PlayerDeath()
    {
        DeathMenu.SetActive(true);        
    }
    public void RestartButton()
    {
        StartCoroutine(ReloadLevel());
    }
    IEnumerator ReloadLevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
    public void HomeButton()
    {
        StartCoroutine(GoToHome());
    }
    IEnumerator GoToHome()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
