﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
		Debug.Log("New Level load: " + name);		
        SceneManager.LoadScene(name);
	}

	public void QuitRequest()
    {      
		Debug.Log("Quit requested");
		Application.Quit();
	}

    public void LoadNextLevel()
    {        
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed() 
    {
        if (Brick.brickCount <= 0) {
            LoadNextLevel();
        }
    }
}
