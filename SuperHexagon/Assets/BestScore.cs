using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour{

    public static BestScore instance;

    private void Awake(){
        instance = this;
    }

    private float score, highScore;

    public Text scoreText, highScoreText, gameOverScoreText;

    //label to hide for new record
    public GameObject scoreLabel;

    void Start(){
        score = 0;
        highScore = splitTime(PlayerPrefs.GetString("HighScore", "0:00"));
        Debug.Log(highScore);
        if(highScore == 0.0){
            highScoreText.text = "NEW RECORD";
            scoreLabel.SetActive(false);
        }else{
            highScoreText.text = PlayerPrefs.GetString("HighScore", "0:00"); //error if 0:00 that is default value
            scoreLabel.SetActive(true);
        }
        highScoreText.alignment = TextAnchor.MiddleRight;
    }

    void Update(){
        score = splitTime(scoreText.text);
        //Debug.Log(score);
        //score = PlayerPrefs.GetFloat("Timer", score);
        if(score > highScore){
            UpdateLabelHighScore();
        }
    }

    void UpdateLabelHighScore(){
        if(highScoreText.text != "NEW RECORD"){
            highScoreText.text = "NEW RECORD";
            scoreLabel.SetActive(false);
        }
        //Debug.Log("EVVIVA");
        highScoreText.alignment = TextAnchor.MiddleRight;
    }

    public void SaveHighScore(){
        score = splitTime(scoreText.text);
        //Debug.Log(score);
        //Debug.Log(scoreText.text);
        if(score > highScore){
            PlayerPrefs.SetString("HighScore", scoreText.text);
        }
    }

    /*void Update(){
        string oldScoreString = PlayerPrefs.GetString("HighScore", highScore.text);
        string timeScoreString = PlayerPrefs.GetString("Timer", time.text);
        float oldScore = splitTime(oldScoreString);
        float timeScore = splitTime(timeScoreString);
        if(oldScore <= timeScore){
            PlayerPrefs.SetString("HighScore", timeScoreString);
            highScore.text = "NEW RECORD";
            scoreLabel.SetActive(false);
        }else{
            highScore.text = oldScoreString;
            scoreLabel.SetActive(true);
        }
        highScore.alignment = TextAnchor.MiddleRight;
    }*/

    public float splitTime(string sequence){
        if(sequence == null){
            return default(float);
        }
        string [] splitTimer = sequence.Split(":"[0]);
        float seconds = float.Parse(splitTimer[0]);
        float tenths = float.Parse(splitTimer[1])/100;
        //Debug.Log("Seconds: " + seconds);
        //Debug.Log("Tenths: " + tenths);
        return seconds + tenths;
    }

    public void ResetHighScore(){
        PlayerPrefs.SetString("HighScore", "0:00");
    }
}
