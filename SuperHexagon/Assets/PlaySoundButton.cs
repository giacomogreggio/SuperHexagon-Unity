using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour{

    public void playSound(){
        DontDestroyOnLoad(AudioManager.audioSrc);
        AudioManager.Play("button");
    }
}
