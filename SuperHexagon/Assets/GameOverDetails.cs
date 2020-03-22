using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDetails : MonoBehaviour{

    public Text level, nextLevel, gameOverScore, highScore, numberOfLevel;

    public GameObject nextLevelLabel;

    // Start is called before the first frame update
    void Start(){
        gameOverScore.text = PlayerPrefs.GetString("GameOverScore", "0:00"); //0:00 the default value meaning error
        float score = splitTime(gameOverScore.text);
        level.text = showLevelReached(score);
        string calculationResult = calculationNextLevelAt(score);
        numberOfLevel.text = showNumberOfLevel(score);
        //Debug.Log(calculationResult);
        if(calculationResult == "max"){
            nextLevelLabel.SetActive(false);
            nextLevel.text = "STAGE COMPLETE";
            highScore.text = "NEW RECORD";
        }else{
            nextLevel.text = calculationResult;
            highScore.text = PlayerPrefs.GetString("HighScore", "0:00");
        }
    }

    //convert time/score string into float
    float splitTime(string sequence){
        if(sequence == null){
            return default(float);
        }
        string [] splitTimer = sequence.Split(":"[0]);
        float seconds = float.Parse(splitTimer[0]);
        float tenths = float.Parse(splitTimer[1])/100;
        return seconds + tenths;
    }

    string calculationNextLevelAt(float score){
        float toNext = 0f;
        if(score >= 60){
            return "max";
        }
        if(score >= 45){
            return "60 SECONDS";
        }
        if(score >= 30){
            return "45 SECONDS";
        }else{
            float initialScore = score;
            while(score >= 10){
                score = score - 10;
            }
            toNext = 10 - score;
            //Debug.Log(toNext);
            float total = initialScore + toNext;
            return total.ToString() + " SECONDS";
        }

    }

    string showLevelReached(float score){
        if(score >= 60){
            return "HEXAGON";
        }
        if(score >=45 && score < 60){
            return "PENTAGON";
        }
        if(score >=30 && score < 45){
            return "SQUARE";
        }
        if(score >=20 && score < 30){
            return "TRIANGLE";
        }
        if(score >=10 && score < 20){
            return "LINE";
        }
        if(score >=0 && score < 10){
            return "POINT";
        }else{
            return "BONUS";
        }
    }

    string showNumberOfLevel(float score){
        if(score >= 60){
            return "6";
        }
        if(score >=45 && score < 60){
            return "5";
        }
        if(score >=30 && score < 45){
            return "4";
        }
        if(score >=20 && score < 30){
            return "3";
        }
        if(score >=10 && score < 20){
            return "2";
        }
        if(score >=0 && score < 10){
            return "1";
        }else{
            return "6";
        }
    }
}
