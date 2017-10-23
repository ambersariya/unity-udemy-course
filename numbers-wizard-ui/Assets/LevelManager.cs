﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevel (string name) {
        Debug.Log("Level " + name + " load requested");
        SceneManager.LoadScene(name);
    }

    public void QuitRequest () {
        Debug.Log("Quit level requested");
        Application.Quit();
    }
}
