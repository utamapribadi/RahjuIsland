using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SCENE1ToggleRestart : MonoBehaviour {
	public float Flag = 1;

	public string SelectScene = "SelectScene";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Flag == 0) {
			SceneManager.LoadScene (SelectScene);
		}
			
	}

	public void toggleInput() {
		Flag = 0;
	}
}
