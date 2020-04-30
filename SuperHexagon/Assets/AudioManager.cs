using System.Collections;
using System.Collections.Generic;
//using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;
//using System;

public class AudioManager : MonoBehaviour{

    public static AudioClip stage1Clip, stage2Clip, stage3Clip, button, startStage, gameOver, explosion, again, excellent, line, triangle, square, pentagon, hexagon, wonderful;
    public static AudioSource audioSrc;

    void Start(){
        
        audioSrc = GetComponent<AudioSource>();

        stage1Clip = Resources.Load<AudioClip>("stage1");
        stage2Clip = Resources.Load<AudioClip>("stage2");
        stage3Clip = Resources.Load<AudioClip>("stage3");
        button = Resources.Load<AudioClip>("button");
        startStage = Resources.Load<AudioClip>("StartStage2");
        again = Resources.Load<AudioClip>("Again");
        gameOver = Resources.Load<AudioClip>("GameOver");
        explosion = Resources.Load<AudioClip>("Explosion");
        excellent = Resources.Load<AudioClip>("Excellent");
        line = Resources.Load<AudioClip>("Line");
        triangle = Resources.Load<AudioClip>("Triangle");
        square = Resources.Load<AudioClip>("Square");
        pentagon = Resources.Load<AudioClip>("Pentagon");
        hexagon = Resources.Load<AudioClip>("Hexagon");
        wonderful = Resources.Load<AudioClip>("Wonderful");
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
            case "button":
                audioSrc.PlayOneShot(button);
                break;
            case "startStage":
                audioSrc.PlayOneShot(startStage);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOver);
                break;
            case "explosion":
                audioSrc.PlayOneShot(explosion);
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
            case "wonderful":
                audioSrc.PlayOneShot(wonderful);
                break;
        }
    }

    public static void Stop(){
        audioSrc.Stop();
    }

    /*
    public Sound[] sounds;

    void Awake(){
        string stageName = PlayerPrefs.GetString("stageName", "");
        foreach(Sound s in sounds){
           
            s.source = gameObject.AddComponent<AudioSource>();
            
            if(stageName == "HEXAGON"){
                s.source.clip = s.clip1;
            }
            if(stageName == "HEXAGONER"){
                s.source.clip = s.clip2;
            }
            if(stageName == "HEXAGONEST"){
                s.source.clip = s.clip3;
            }
            //s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public  void Play(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }*/
}
