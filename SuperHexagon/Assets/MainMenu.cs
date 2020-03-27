using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    GameObject optionMenus;
    
    public void PlayGame(){
        SceneManager.LoadScene("SelectStage");
    }

    public void QuitGame(){
        //Debug.Log("Quit");
        Application.Quit();
    }

    public void savePreviousScene(){
        Debug.Log(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("CurrentScene", SceneManager.GetActiveScene().name);
    }

    public void OptionsGame(){
        SceneManager.LoadScene("Options");
    }

}
