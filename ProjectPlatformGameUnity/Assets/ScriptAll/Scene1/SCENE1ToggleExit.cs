using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCENE1ToggleExit : MonoBehaviour {
	public float Flag = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Flag == 0) {
			Application.Quit ();
		}


	}

	public void toggleInput() {
		Flag = 0;
	}
}
