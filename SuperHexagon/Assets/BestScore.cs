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
        //ResetHighScore();
        score = 0;
        savedHighScore = "";
        if(PlayerPrefs.GetString("stageName","") == "HEXAGON"){
            savedHighScore = PlayerPrefs.GetString("HighScore1", "0:00");
            highScore = splitTime(savedHighScore);
            Debug.Log(highScore);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONER"){
            savedHighScore = PlayerPrefs.GetString("HighScore2", "0:00");
            highScore = splitTime(savedHighScore);
            Debug.Log(highScore);
        }
        if(PlayerPrefs.GetString("stageName","") == "HEXAGONEST"){
            savedHighScore = PlayerPrefs.GetString("HighScore3", "0:00");
            highScore = splitTime(savedHighScore);
            Debug.Log(highScore);
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
        if(score > highScore){
            UpdateLabelHighScore();
        }
    }

    void UpdateLabelHighScore(){
        if(highScoreText.text != "NEW RECORD"){
            highScoreText.text = "NEW RECORD";
            scoreLabel.SetActive(false);
        }
        highScoreText.alignment = TextAnchor.MiddleRight;
    }

    public void SaveHighScore(){
        score = splitTime(scoreText.text);
        //Debug.Log(score);
        //Debug.Log(scoreText.text);
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
}
