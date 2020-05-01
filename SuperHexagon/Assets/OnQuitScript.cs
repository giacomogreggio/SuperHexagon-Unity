using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnQuitScript : MonoBehaviour{

    //this method is used for entry voice in main menu such as if I quit the game in another scene the voice is reset
    void OnApplicationQuit(){
        PlayerPrefs.SetInt("startApp", 1);
    }

}
