using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public Text time;

    private void Update()
    {
        time.text = GetTimeString(TimeManager.Instance.GetRemainingTime() + 1);
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

    // mengubah waktu menjadi string
    private string GetTimeString(float timeRemaining)
    {
        int minute = Mathf.FloorToInt(timeRemaining / 60);
        int second = Mathf.FloorToInt(timeRemaining % 60);

        return string.Format("{0} : {1}", minute.ToString(), second.ToString());
    }
}
