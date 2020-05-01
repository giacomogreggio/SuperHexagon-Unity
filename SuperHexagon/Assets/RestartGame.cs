using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour{

    // restart game from game over scene
    public void Restart(){
        SceneManager.LoadScene("Game");
    }
}
