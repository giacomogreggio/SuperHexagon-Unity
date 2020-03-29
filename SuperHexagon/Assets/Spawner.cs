using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

    float spawnRate = 1f;

    float nextSpawn = 1f; //default max level 1f

    public GameObject hexagonPrefab;

    private float nextTimeToSpawn = 0f;

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
