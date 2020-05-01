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

    private string savedHighScore;

    public Text scoreText, highScoreText;

    //label to hide for new record
    public GameObject scoreLabel;

    void Start(){
        ResetVoices();
        score = 0;
        savedHighScore = "";
        if(PlayerPrefs.GetString("stageName","") == "HEXAGON"){
            savedHighScore = PlayerPrefs.GetString("HighScore1", "0:00");
            highScore = splitTime(savedHighScore);
            //Debug.Log(highScore);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONER"){
            savedHighScore = PlayerPrefs.GetString("HighScore2", "0:00");
            highScore = splitTime(savedHighScore);
            //Debug.Log(highScore);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONEST"){
            savedHighScore = PlayerPrefs.GetString("HighScore3", "0:00");
            highScore = splitTime(savedHighScore);
            //Debug.Log(highScore);
        }
        if(highScore == 0.0){
            highScoreText.text = "NEW RECORD";
            scoreLabel.SetActive(false);
        }else{
            if(savedHighScore != ""){
                highScoreText.text = savedHighScore; //error if 0:00 that is default value
            }else{
                Debug.Log("Error occured during getting stageName");
            }
            scoreLabel.SetActive(true);
        }
        highScoreText.alignment = TextAnchor.MiddleRight;
    }

    void Update(){
        score = splitTime(scoreText.text);
        //Debug.Log(score);
        timerSound();
        if(score > highScore){
            UpdateLabelHighScore();
        }
    }

    void UpdateLabelHighScore(){
        if(highScoreText.text != "NEW RECORD"){
            highScoreText.text = "NEW RECORD";
            scoreLabel.SetActive(false);
            AudioManager.Play("excellent");
        }
        highScoreText.alignment = TextAnchor.MiddleRight;
    }

    public void SaveHighScore(){
        score = splitTime(scoreText.text);
        if(score > highScore){
            setHighScore();
        }
        setGameOverScore();
    }

    void setHighScore(){
        if(PlayerPrefs.GetString("stageName","") == "HEXAGON"){
            PlayerPrefs.SetString("HighScore1", scoreText.text);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONER"){
            PlayerPrefs.SetString("HighScore2", scoreText.text);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONEST"){
            PlayerPrefs.SetString("HighScore3", scoreText.text);
        }
    }

    void setGameOverScore(){
        PlayerPrefs.SetString("GameOverScore", scoreText.text);
    }

    //convert time/score string into float
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

    //play voices when a new level is reached
    void timerSound(){
        int line = PlayerPrefs.GetInt("line", 0);
        int triangle = PlayerPrefs.GetInt("triangle", 0);
        int square = PlayerPrefs.GetInt("square", 0);
        int pentagon = PlayerPrefs.GetInt("pentagon", 0);
        int hexagon = PlayerPrefs.GetInt("hexagon", 0);
        if(score >= 10 && score <20 && line == 0){
            AudioManager.Play("line");
            PlayerPrefs.SetInt("line", 1);
        }
        if(score >= 20 && score <30 && triangle == 0){
            AudioManager.Play("triangle");
            PlayerPrefs.SetInt("triangle", 1);
        }
        if(score >= 30 && score <45 && square == 0){
            AudioManager.Play("square");
            PlayerPrefs.SetInt("square", 1);
        }
        if(score >= 45 && score <60 && pentagon == 0){
            AudioManager.Play("pentagon");
            PlayerPrefs.SetInt("pentagon", 1);
        }
        if(score >= 60 && score <999 && hexagon == 0){
            AudioManager.Play("hexagon");
            PlayerPrefs.SetInt("hexagon", 1);
        }
    }

    public float getScore(){
        return score;
    }

    //reset level voices of the stage
    void ResetVoices(){
        PlayerPrefs.SetInt("line", 0);
        PlayerPrefs.SetInt("triangle", 0);
        PlayerPrefs.SetInt("square", 0);
        PlayerPrefs.SetInt("pentagon", 0);
        PlayerPrefs.SetInt("hexagon", 0);
    }
}
