using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersWizard : MonoBehaviour {

    int min;
    int max;
    int guess;

	// Use this for initialization
	void Start () {

        StartGame();
	}

    private void StartGame()
    {
		min = 1;
		max = 1000;
        guess = 500;

        print("----------------------------------------------");
		print("Welcome to Numbers Wizard");
		print("Think of a number but keep it to yourself");
		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);

		print("Is the number higher or lower than " + guess + "?");
		print("Up = higher, Down = lower, return = equal");

		max += 1;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            
            min = guess;
            NextGuess();
        
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            
			max = guess;
            NextGuess();
        
        } else if (Input.GetKeyDown(KeyCode.Return)) {
        
            print("I won!");
            StartGame();
        }
	}

    void NextGuess() {
		guess = (min + max) / 2;
		print("Higher or lower than " + guess);
	}
}
