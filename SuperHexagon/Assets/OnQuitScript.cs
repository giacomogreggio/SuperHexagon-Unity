using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnQuitScript : MonoBehaviour{

    void OnApplicationQuit(){
        PlayerPrefs.SetInt("startApp", 1);
    }

}
