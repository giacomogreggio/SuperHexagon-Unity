using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    GameObject optionMenu;
    
    public void PlayGame(){
        SceneManager.LoadScene("SelectStage");
    }

    public void QuitGame(){
        //Debug.Log("Quit");
        Application.Quit();
    }
}
