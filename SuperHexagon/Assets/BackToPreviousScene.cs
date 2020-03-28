using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToPreviousScene : MonoBehaviour{

    public void verifyPreviousScene(){
        string scene = PlayerPrefs.GetString("CurrentScene", "");
        if(scene != ""){
            SceneManager.LoadScene(scene);
        }else{
            Debug.Log("A problem occured! We are sorry :( Please reopen the application!");
        }
    }

    public void verifyPreviousSceneTutorial(){
        string scene = PlayerPrefs.GetString("CurrentSceneForTutorial", "");
        if(scene != ""){
            SceneManager.LoadScene(scene);
        }else{
            Debug.Log("A problem occured! We are sorry :( Please reopen the application!");
        }
    } 

}
