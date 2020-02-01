using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour{

    public Text scoreText;
    public GameObject scoreLabel;

    void Start(){
        scoreText.text = "NEW RECORD";
        scoreText.alignment = TextAnchor.MiddleRight;
    }

    // Update is called once per frame
    void Update(){
        if(scoreText.text == "NEW RECORD"){
            scoreLabel.SetActive(false);
        }
    }
}
