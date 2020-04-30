using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour{


    void Start(){
        Slider slider = GetComponent<Slider>();
        if(slider != null){
            slider.normalizedValue = PlayerPrefs.GetFloat("volume", 0.5f);
        }
    }
}
