using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{

    float moveSpeed = 400f;
    float movement = 0f;

    // player movement
    void Update(){
        if(Input.touchCount > 0){
            Touch t = Input.GetTouch(0);
            if(t.position.x > Screen.width /2){
                movement = 1;
            }else{
                movement = -1;
            }
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        }
    }

    // Trigger gameover scene when player collide with hexagon
    void OnTriggerEnter2D(Collider2D collision){
        BestScore.instance.SaveHighScore();
        SceneManager.LoadScene("GameOver");
    }
}
