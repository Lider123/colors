using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Sprite layer_blue, layer_pink;
	public GameObject music_on, music_off;

	// Use this for initialization
	void Start () {
		if (gameObject.name == "Music") {
			if (PlayerPrefs.GetString ("Music") == "no") {
				music_on.SetActive (false);
				music_off.SetActive (true);
			} else {
				music_on.SetActive (true);
				music_off.SetActive (false);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		GetComponent<SpriteRenderer> ().sprite = layer_pink;
	}

	void OnMouseUp() {
		GetComponent<SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton() {
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("Click Audio").GetComponent<AudioSource> ().Play ();
		switch (gameObject.name) {
		case "Play":
			Application.LoadLevel("play");
			break;
		case "Replay":
			Application.LoadLevel("play");
			break;
		case "Rating":
			Application.OpenURL("https://play.google.com/store/apps/details?id=com.example.colors");
			break;
		case "Home":
			Application.LoadLevel("main");
			break;
		case "Facebook":
			Application.OpenURL("http://facebook.com");
			break;
		case "How To":
			Application.LoadLevel("howTo");
			break;
		case "Close":
			Application.LoadLevel("main");
			break;
		case "Music":
			if (PlayerPrefs.GetString("Music") == "yes") {
				PlayerPrefs.SetString("Music", "no");
				music_on.SetActive(false);
				music_off.SetActive(true);
			}
			else {
				PlayerPrefs.SetString("Music", "yes");
				music_on.SetActive(true);
				music_off.SetActive(false);
			}
			break;
		}
	}
}
