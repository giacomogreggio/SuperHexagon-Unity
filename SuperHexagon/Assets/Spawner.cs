using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour{

    float spawnRate = 1f;

    float nextSpawn = 1f; //default max level 1f

    public GameObject hexagonPrefab;

    private float nextTimeToSpawn = 0f;

    void Start() {
        string stageName = PlayerPrefs.GetString("stageName", "");
        AudioManager.Play("again");
        AudioManager.Play("startStage");
        if(stageName == "HEXAGON"){
            AudioManager.Play("stage1");
        }
        if(stageName == "HEXAGONER"){
            AudioManager.Play("stage2");
        }
        if(stageName == "HEXAGONEST"){
            AudioManager.Play("stage3");
        }
        //FindObjectOfType<AudioManager>().Play("StageSong");
    }

    // Update is called once per frame
    void Update(){
        nextSpawn = PlayerPrefs.GetFloat("nextSpawn", 0f);
        if(nextSpawn != 0f){
            if(Time.time >= nextTimeToSpawn){
                Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + nextSpawn / spawnRate;
            }
        }
    }
}
