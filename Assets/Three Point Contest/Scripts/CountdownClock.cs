using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CountdownClock : MonoBehaviour
{
    public float timeRemaining;
    public TextMeshProUGUI timerText;
    public bool beginOnStart;
    public UnityEvent onFinished;

    private bool isCounting;

    private void Start()
    {
        if (beginOnStart)
        {
            isCounting = true;
        }
    }


    void Update()
    {
        if (isCounting)
        {
            RunTimer();
        }
    }

    private void RunTimer()
    {
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timerText.text = "0";
            onFinished.Invoke();
            print("finished");
            isCounting = false;
        }
        else
        {
            timerText.text = timeRemaining.ToString("F");
        }
    }
}
