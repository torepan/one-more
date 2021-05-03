using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    
    public float countdown = 5.0f;

    
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
       
        countdown -= Time.deltaTime;

        
        timeText.text = countdown.ToString("f1") + "•b";

        
        if (countdown <= 0)
        {
            timeText.text = "Time Up";
        }
    }
}