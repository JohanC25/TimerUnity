using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerDuration = 60.0f;
    private float currentTime = 0.0f;
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = timerDuration;
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0.0f)
        {           
            currentTime = 0.0f;

        }

        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
