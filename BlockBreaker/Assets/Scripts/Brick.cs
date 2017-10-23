using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int timesHit;
    private LevelManager levelManager;
    public Sprite[] hitSprites;
    public static int brickCount = 0;
    private bool isBreakable;
    public AudioClip crack;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        timesHit = 0;
        isBreakable = (this.tag == "breakable");

        //let's keep track of breakable bricks
        if (isBreakable) {
            Brick.brickCount++;
        }
	}
	
	// Update is called once per frame
	void Update () {
        GetNumberOfBreakableBricks();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isBreakable) {
            AudioSource.PlayClipAtPoint(crack, transform.position, 0.8F);
            HandleHits();   
        }
    }

    private void HandleHits() {

        timesHit++;
        int maxHits = hitSprites.Length + 1;

        if (timesHit >= maxHits)
        {
            
            Brick.brickCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    private void SimulateWin() {

        levelManager.LoadNextLevel();
    }

    public static int GetNumberOfBreakableBricks() {
        return brickCount;
    }
}
