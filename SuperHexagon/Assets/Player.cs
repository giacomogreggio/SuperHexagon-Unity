using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{

    float moveSpeed = 400f;
    float movement = 0f;

    // Update is called once per frame
    void Update(){
        /* Keyboard movement with arrows */
        //movement = Input.GetAxisRaw("Horizontal");
        //Debug.Log(movement);
        if(Input.touchCount > 0){
            Touch t = Input.GetTouch(0);
            if(t.position.x > Screen.width /2){
                movement = 1;
            }else{
                movement = -1;
            }
        //playing from keyboard required this line into FixedUpdateMethod
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        BestScore.instance.SaveHighScore();
        
        //FindObjectOfType<AudioManager>().Play("");
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("GameOver");
    }
}
