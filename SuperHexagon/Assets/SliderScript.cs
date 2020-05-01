using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour{

    public Text volumeSlider;

    // these methods set slider in the option scene and the volume of sounds and voices

    void Start(){
        Slider slider = GetComponent<Slider>();
        if(slider != null){
            slider.normalizedValue = PlayerPrefs.GetFloat("volume", 0.5f);
            volumeSlider.text = Mathf.RoundToInt(PlayerPrefs.GetFloat("volume", 0.5f)*100).ToString();
        }
    }

    void Update(){
        volumeSlider.text = Mathf.RoundToInt(PlayerPrefs.GetFloat("volume", 0.5f)*100).ToString();
    }
}
