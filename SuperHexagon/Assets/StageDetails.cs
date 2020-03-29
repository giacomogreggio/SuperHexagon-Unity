using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageDetails : MonoBehaviour{
 
    public Text highScore1, highScore2, highScore3;

    void Start(){
        string stageName = PlayerPrefs.GetString("stageName", "");
        highScore1.text = PlayerPrefs.GetString("HighScore1", "0:00");
        highScore2.text = PlayerPrefs.GetString("HighScore2", "0:00");
        highScore3.text = PlayerPrefs.GetString("HighScore3", "0:00");
        //Debug.Log("In the beginning of application there aren't any highscore");
    }
}
