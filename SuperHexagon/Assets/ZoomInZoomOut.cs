using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInZoomOut : MonoBehaviour {

	Camera mainCamera;

	private float startTime;
	private int count = 1;

	// Create a dynamics camera for the game scene
	void Start () {
		mainCamera = GetComponent<Camera> ();
		PlayerPrefs.SetInt("zoom", 0);
		startTime = Time.time;

	}
	
	void Update () {
		float updateCount = 1f* count;
		float deltaTime = Time.time - startTime;
		if(deltaTime > updateCount){
			if(PlayerPrefs.GetInt("zoom", 0) == 0){
				ZoomOut();
				PlayerPrefs.SetInt("zoom", 1);
			}else{
				ZoomIn();
				PlayerPrefs.SetInt("zoom", 0);
			}
			count++;
			mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, 2f, 10f);
		}
	}

	void ZoomOut(){
		mainCamera.orthographicSize -= 0.2f;
    }
	
	void ZoomIn(){
		mainCamera.orthographicSize += 0.2f;
    }
}


