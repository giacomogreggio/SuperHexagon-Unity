using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour{

    public Text stageName;

    // start game from select stage scene
    public void RestartGame(){
        if(stageName.text == "HEXAGON"){
            PlayerPrefs.SetFloat("nextSpawn", 2f);
        }
        if(stageName.text == "HEXAGONER"){
            PlayerPrefs.SetFloat("nextSpawn", 1.5f);
        }
        if(stageName.text == "HEXAGONEST"){
            PlayerPrefs.SetFloat("nextSpawn", 1f);
        }
        PlayerPrefs.SetString("stageName", stageName.text);
        SceneManager.LoadScene("Game");
    }

}
