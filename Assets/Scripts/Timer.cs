using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    float timeRunning = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        timeRunning -= Time.deltaTime;


        string seconds = timeRunning.ToString("f2");

        timer.text = "Time Remaining: " + seconds;

        if (timeRunning <= 0.0f)
        {
            timeRunning = 10;
        }

        if (Input.GetButtonDown("Jump")){
            timeRunning = 10;
        }
    }
    
}
