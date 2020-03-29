using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToTutorial : MonoBehaviour{
        
    public void savePreviousScene(){
        Debug.Log(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("CurrentSceneForTutorial", SceneManager.GetActiveScene().name);
    }

    public void toTutorial(){
        SceneManager.LoadScene("Tutorial");
    }
}
