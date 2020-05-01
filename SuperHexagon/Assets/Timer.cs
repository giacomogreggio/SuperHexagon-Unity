using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour{

    public Text timerText;
    private float startTime;
    float timerCopy;

    void Start(){
        startTime = Time.time;
    }

    void Update(){
        float t = Time.time - startTime;
        
        int timer = (int)(t * 100.0f);
        //Debug.Log(timer);
        string seconds = ((timer % (1000 * 100)) / 100).ToString();
        string tenths = (timer % 100).ToString("D2");

        timerText.text = seconds + ":" + tenths;
        timerCopy = BestScore.instance.splitTime(timerText.text);
        LevelComplete();
    }

    void LevelComplete(){
        if(timerCopy >= 999 && timerCopy < 999.5){
            BestScore.instance.SaveHighScore();
            SceneManager.LoadScene("GameOver");
        }
    }
}
