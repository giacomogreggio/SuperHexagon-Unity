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
        
        int timer = (int)(t * 100.0f);
        string seconds = ((timer % (60 * 100)) / 100).ToString();
        string tenths = (timer % 100).ToString("D2");

        timerText.text = seconds + ":" + tenths;
    }
}
