using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour{

    public static AudioClip clip;
    public static AudioSource src;

    void Start(){
        clip = Resources.Load<AudioClip>("button");
        src = GetComponent<AudioSource>();
    }

    //generic method for button sound
    public void playSound(){
        DontDestroyOnLoad(src);
        src.PlayOneShot(clip);
    }
}
