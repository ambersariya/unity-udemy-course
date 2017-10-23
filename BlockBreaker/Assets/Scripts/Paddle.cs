using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;
    private Ball ball;



	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        if(!autoPlay) {
            MoveWithMouse();
        }
        else {
            AutoPlay();
        }
    }

    private void AutoPlay()
    {        
        Vector3 ballPosition = ball.transform.position;
        Vector3 paddlePosition = new Vector3(
            Mathf.Clamp(ballPosition.x, 0.5f, 15.5f),
            this.transform.position.y,
            1.0f
        );

        this.transform.position = paddlePosition;
    }

    private void MoveWithMouse()
    {
        float relativeMousePosition = (Input.mousePosition.x / Screen.width) * 16;

        Vector3 position = new Vector3(
            Mathf.Clamp(relativeMousePosition, 0.5f, 15.5f),
            this.transform.position.y,
            1.0f
        );

        this.transform.position = position;
    }
}
