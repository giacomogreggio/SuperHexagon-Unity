using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour{

    public RectTransform stage1, stage2, stage3;
    // Start is called before the first frame update
    void Start(){
        stage1.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void ToSecondStage(){
        stage1.DOAnchorPos(new Vector2(-1954,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(0,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(1954,0), 0.25f);
    }

    public void ToFirstStage(){
        stage1.DOAnchorPos(new Vector2(0,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(1954,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(3899,0), 0.25f);
    }

    public void ToThirdStage(){
        stage1.DOAnchorPos(new Vector2(-3899,0), 0.25f);
        stage2.DOAnchorPos(new Vector2(-1954,0), 0.25f);
        stage3.DOAnchorPos(new Vector2(0,0), 0.25f);
    }
}
