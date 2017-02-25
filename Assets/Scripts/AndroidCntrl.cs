using UnityEngine;
using System.Collections;

public class AndroidCntrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			switch(Application.loadedLevelName) {
			case "main":
				Application.Quit();
				break;
			case "play":
				Application.LoadLevel("main");
				break;
			}
		}
	}
}
