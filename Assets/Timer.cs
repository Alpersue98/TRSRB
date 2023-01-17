using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    bool timerActive = false;
    bool timerDone = false;
    public Slider sessionTime;

    public float displayTime;

    public TextMeshProUGUI currentTimeText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive == true)
        {
            displayTime = displayTime - Time.deltaTime;

            if(displayTime <= 0 )
            {
                timerActive = false;
                timerDone = true;
                
                Debug.Log("Timer finished!");
            }
        }

        TimeSpan time = TimeSpan.FromSeconds(displayTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();










        
    }

    public void StartTimer()
    {
        if (sessionTime.value >= 1)
        {
            timerActive = true;
            displayTime = (int)sessionTime.value * 60;
            
            
        }
        else
        {
            timerActive = true;
            displayTime = 1 * 60;
            
        }
    }

    public void PauseTimer()
    {
        timerActive = false;

    }

    public void StopTimer()
    {
        timerActive = false;

    }
}
