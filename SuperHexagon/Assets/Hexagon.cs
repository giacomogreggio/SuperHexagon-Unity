using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour{

    public Rigidbody2D rb;

    public float shrinkSpeed = 3f; //how fast hexagon close

    void Start(){
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
        
    }

    // hexagons that is closing during the game
    void Update(){
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if(transform.localScale.x <= .05f){
            Destroy(gameObject);
        } 
    }
}
