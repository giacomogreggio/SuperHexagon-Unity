using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{

    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start(){
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update(){
        float t = Time.time - startTime;
        //string minutes = ((int) t / 60).ToString();

//    return String.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, hundredths);
        int timer = (int)(t * 100.0f);
        string seconds = ((timer % (60 * 100)) / 100).ToString();
        string tenths = (timer % 100).ToString();

        timerText.text = seconds + ":" + tenths;
    }
}
