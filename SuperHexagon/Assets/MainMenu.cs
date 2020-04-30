using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    public static AudioClip startClip;
    public static AudioSource src;

    void Start(){
        int start = PlayerPrefs.GetInt("startApp", 0);
        startClip = Resources.Load<AudioClip>("start");
        src = GetComponent<AudioSource>();
        if(start == 1){
            src.volume = PlayerPrefs.GetFloat("volume", 1f);
            src.PlayOneShot(startClip);
            PlayerPrefs.SetInt("startApp", 0);
        }
    }

    GameObject optionMenus;
    
    public void PlayGame(){
        SceneManager.LoadScene("SelectStage");
    }

    void OnApplicationQuit(){
        PlayerPrefs.SetInt("startApp", 1);
    }

    public void QuitGame(){
        //Debug.Log("Quit");
        PlayerPrefs.SetInt("startApp", 1);
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
