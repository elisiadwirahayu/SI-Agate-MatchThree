﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
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
