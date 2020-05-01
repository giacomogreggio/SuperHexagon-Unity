using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHexagon : MonoBehaviour{


    // hexagon in select stage scene background and game over scene background
    void Update(){
        transform.Rotate(new Vector3(0f, 0f, 50f) * Time.deltaTime);
    }
}
