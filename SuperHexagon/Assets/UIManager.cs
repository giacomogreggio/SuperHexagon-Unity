using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour{

    // controls the different stages and buttons that bring from a stage to another stage
    public Text stage1Text, stage2Text, stage3Text;

    public RectTransform stage1, stage2, stage3;

    void Start(){
        stage1.DOAnchorPos(Vector2.zero, 0.25f);
        string stageName = PlayerPrefs.GetString("stageName", "");
        if(stageName == ""){
            Debug.Log("Error occured during loading right stage");
        }
        if(stage1Text.text != stageName){
            ToSecondStage();
            if(stage2Text.text != stageName){
                ToThirdStage();
            }
        }
    }

    public void ToSecondStage(){
        PlayerPrefs.SetString("stageName", stage2Text.text);
        stage1.DOAnchorPos(new Vector2(-1954,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(0,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(1954,0), 0.25f);
    }

    public void ToFirstStage(){
        PlayerPrefs.SetString("stageName", stage1Text.text);
        stage1.DOAnchorPos(new Vector2(0,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(1954,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(3899,0), 0.25f);
    }

    public void ToThirdStage(){
        PlayerPrefs.SetString("stageName", stage3Text.text);
        stage1.DOAnchorPos(new Vector2(-3899,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(-1954,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(0,0), 0.25f);
    }
}
