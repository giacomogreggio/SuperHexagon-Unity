using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour{

    public static AudioClip stage1Clip, stage2Clip, stage3Clip, startStage, again, excellent, line, triangle, square, pentagon, hexagon;
    public static AudioSource audioSrc;

    void Awake() {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.Stop();
    }

    void Start(){

        stage1Clip = Resources.Load<AudioClip>("stage1");
        stage2Clip = Resources.Load<AudioClip>("stage2");
        stage3Clip = Resources.Load<AudioClip>("stage3");
        startStage = Resources.Load<AudioClip>("StartStage2");
        again = Resources.Load<AudioClip>("Again");
        excellent = Resources.Load<AudioClip>("Excellent");
        line = Resources.Load<AudioClip>("Line");
        triangle = Resources.Load<AudioClip>("Triangle");
        square = Resources.Load<AudioClip>("Square");
        pentagon = Resources.Load<AudioClip>("Pentagon");
        hexagon = Resources.Load<AudioClip>("Hexagon");
    }

    public static void Play(string clip){
        switch(clip){
            case "stage1":
                audioSrc.clip = stage1Clip;
                audioSrc.loop = true;
                audioSrc.Play();
                break;
            case "stage2":
                audioSrc.clip = stage2Clip;
                audioSrc.loop = true;
                audioSrc.Play();
                break;
            case "stage3":
                audioSrc.clip = stage3Clip;
                audioSrc.loop = true;
                audioSrc.Play();
                break;
            case "startStage":
                audioSrc.PlayOneShot(startStage);
                break;
            case "again":
                audioSrc.PlayOneShot(again);
                break;
            case "excellent":
                audioSrc.PlayOneShot(excellent);
                break;
            case "line":
                audioSrc.PlayOneShot(line);
                break;
            case "triangle":
                audioSrc.PlayOneShot(triangle);
                break;
            case "square":
                audioSrc.PlayOneShot(square);
                break;
            case "pentagon":
                audioSrc.PlayOneShot(pentagon);
                break;
            case "hexagon":
                audioSrc.PlayOneShot(hexagon);
                break;
        }
    }

    public static void Stop(){
        audioSrc.Stop();
    }
}
