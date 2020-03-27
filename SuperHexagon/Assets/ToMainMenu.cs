using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToMainMenu : MonoBehaviour{

    public static ToMainMenu instance;

    public void ReachMainMenu(){
        SceneManager.LoadScene("Menù");
    }

    public void savePreviousScene(){
        Debug.Log(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("CurrentScene", SceneManager.GetActiveScene().name);
    }

    public void toOptionMenu(){
        SceneManager.LoadScene("Options");
    }

}
