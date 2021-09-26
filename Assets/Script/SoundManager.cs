using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton

    // membuat SoundManager sebagai singleton

    private static SoundManager _instance = null;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SoundManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public AudioClip scoreNormal;
    public AudioClip scoreCombo;
    public AudioClip wrongMove;
    public AudioClip tap;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    // mengatur sound untuk score
    public void PlayScore(bool isCombo)
    {
        if (isCombo)
        {
            // mengatur sound untuk score combo
            player.PlayOneShot(scoreCombo);
        }
        else
        {
            // mengatur sound untuk score normal
            player.PlayOneShot(scoreNormal);
        }
    }

    // mengatur sound untuk movement yang salah
    public void PlayWrong()
    {
        player.PlayOneShot(wrongMove);
    }

    // mengatur sound saat tile di tap
    public void PlayTap()
    {
        player.PlayOneShot(tap);
    }
}
