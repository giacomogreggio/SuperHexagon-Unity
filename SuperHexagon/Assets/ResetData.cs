using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData : MonoBehaviour{

    public void ResetHighScore(){
        PlayerPrefs.SetString("HighScore", "0:00");
    }

}
