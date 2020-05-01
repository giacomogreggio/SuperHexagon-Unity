using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour{
    
    Color bgcolor;
    Color current;
    float t = 0.0f;
    float increment = 0.02f;

    public void Start () {
         StartCoroutine(Change_color());
    }
    
    //change background color during game
    IEnumerator Change_color(){
        current = bgcolor;
        bgcolor = new Color(Random.value, Random.value, Random.value);
        while (t < 2){
            Camera.main.backgroundColor = Color.Lerp(current, bgcolor, t);
            t += increment;
            yield return new WaitForSeconds(increment);
        }
        t = 0.0f;
        current = bgcolor;
        yield return new WaitForSeconds(Random.Range (3,6));
        StartCoroutine (Change_color());
    }
}
