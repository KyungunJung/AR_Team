using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public float time = 9f;
    private float selectCountdown;

    void Start()
    {
        selectCountdown = time;
    }

    void Update()
    {
        if (Mathf.Floor(selectCountdown) <= 0)
        {
            // Count 0�϶� ������ �Լ� ����
        }
        else
        {
            selectCountdown -= Time.deltaTime;
            timerTxt.text = "Time : " + Mathf.Floor(selectCountdown).ToString();
        }
    }
}