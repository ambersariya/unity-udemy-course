using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer instance;

    private void Awake()
    {
        Debug.Log("Music player is Awake " + GetInstanceID());
        //if we don't have an instance set yet
        if (instance == null) {
            instance = this;
            //otherwise, if we do, kill this thing
        } else {
            Destroy(gameObject);
            Debug.Log("self-destructing music player");
        }

        DontDestroyOnLoad(gameObject);  
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

	}
}
