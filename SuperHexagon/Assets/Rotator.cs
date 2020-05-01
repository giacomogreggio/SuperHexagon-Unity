using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour{
    
    void Update(){
        transform.Rotate(Vector3.forward, Time.deltaTime * -20f);
    }
}
