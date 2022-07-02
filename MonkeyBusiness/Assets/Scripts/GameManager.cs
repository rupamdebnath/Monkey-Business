using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject DeathMenu;

    public GameObject ScoreText;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void PlayerDeath()
    {
        DeathMenu.SetActive(true);
        ScoreText.GetComponent<TextMeshProUGUI>().SetText("Your Score:" + CalculateScore.instance.FetchScore());
        SoundManager.instance.StopSound(0);
        SoundManager.instance.PlaySound(3);
    }
    public void RestartButton()
    {
        StartCoroutine(ReloadLevel());
    }
    IEnumerator ReloadLevel()
    {
        SoundManager.instance.PlaySound(1);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
        SoundManager.instance.PlaySound(0);
    }
    public void HomeButton()
    {
        StartCoroutine(GoToHome());
    }
    IEnumerator GoToHome()
    {
        SoundManager.instance.PlaySound(1);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
