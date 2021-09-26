using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int highScore;

    #region Singleton

    // membuat ScoreManager sebagai singleton

    private static ScoreManager _instance = null;

    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: ScoreManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int tileRatio;
    public int comboRatio;

    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }

    private int currentScore;

    private void Start()
    {
        // me reset scrore sekarang
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
       // membuat score sekarang menjadi 0
        currentScore = 0;
    }

    // menambahkan score
    public void IncrementCurrentScore(int tileCount, int comboCount)
    {
        currentScore += (tileCount * tileRatio) * (comboCount * comboRatio);

        SoundManager.Instance.PlayScore(comboCount > 1);
    }

    // mengatur high score
    public void SetHighScore()
    {
        highScore = currentScore;
    }
}
