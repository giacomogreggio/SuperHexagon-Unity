using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageDetails : MonoBehaviour{
 
    public Text highScore, difficulty, stageName;

    void Start(){
        stageName.text = "HEXAGONER";
        difficulty.text = setDifficulty();
        highScore.text = PlayerPrefs.GetString("HighScore", "0:00");
    }

    string setDifficulty(){
        if(stageName.text == "HEXAGON"){
            return "HARD";
        }
        if(stageName.text == "HEXAGONER"){
            return "HARDER";
        }else{
            return "HARDEST";
        }
    }
}
