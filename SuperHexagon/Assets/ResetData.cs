using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour{

    // reset the game data
    public void ResetHighScore(){
        PlayerPrefs.SetString("HighScore1", "0:00");
        PlayerPrefs.SetString("HighScore2", "0:00");
        PlayerPrefs.SetString("HighScore3", "0:00");
    }

}
