using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateScore : MonoBehaviour
{
    public static CalculateScore instance;

    private TextMeshProUGUI scoreText;

    private int scoreValue=0;

    private void Awake()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        scoreText.SetText("Score:" + scoreValue);
    }

    public void NormalScore()
    {
        scoreValue += 10;
    }
    public void ExtraScore()
    {
        scoreValue += 50;
    }

    public int FetchScore()
    {
        return scoreValue;
    }
}
