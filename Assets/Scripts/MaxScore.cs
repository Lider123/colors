﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = PlayerPrefs.GetInt ("Score").ToString();
	}
}
