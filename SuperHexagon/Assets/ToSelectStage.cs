using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToSelectStage : MonoBehaviour{

    public void ReachSelectStage(){
        SceneManager.LoadScene("SelectStage");
    }

}
