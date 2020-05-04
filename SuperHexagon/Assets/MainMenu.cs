using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

    public static AudioClip startClip;
    public static AudioSource src;

    void Awake() {
        //PlayerPrefs.SetInt("first", 0);
        int first = PlayerPrefs.GetInt("first", 0);
        if(first == 0){
            ResetData.initialReset();
            PlayerPrefs.SetString("CurrentSceneForTutorial", SceneManager.GetActiveScene().name);
            PlayerPrefs.SetInt("first", 1);
            SceneManager.LoadScene("Tutorial");
        }
    }
    
    void Start(){
        int start = PlayerPrefs.GetInt("startApp", 1);
        startClip = Resources.Load<AudioClip>("start");
        src = GetComponent<AudioSource>();
        if(start == 1){
            src.volume = PlayerPrefs.GetFloat("volume", 1f);
            StartCoroutine(WaitToRing());
            PlayerPrefs.SetInt("startApp", 0);
        }
    }

    //this method is used for entry voice of the game in main menu
    IEnumerator WaitToRing(){
        yield return new WaitForSeconds(1f);
        src.PlayOneShot(startClip);
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
        //Debug.Log(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("CurrentScene", SceneManager.GetActiveScene().name);
    }

    public void OptionsGame(){
        SceneManager.LoadScene("Options");
    }

}
