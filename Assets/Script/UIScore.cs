using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text highScore;
    public Text currentScore;

    private void Update()
    {
        highScore.text = ScoreManager.Instance.HighScore.ToString();
        currentScore.text = ScoreManager.Instance.CurrentScore.ToString();
    }

    public void Show()
    {
        // menampilkan gameObject
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        // menyembunyikan gameObject
        gameObject.SetActive(false);
    }
}
