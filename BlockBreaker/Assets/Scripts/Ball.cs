using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private bool hasStarted;

	// Use this for initialization
	void Start () {
        paddle = FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {

        if(!hasStarted) {
            
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("Pressed left click. Launch Ball");
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            } 
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ballTweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));

        if(hasStarted) {            
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            GetComponent<Rigidbody2D>().velocity += ballTweak;
        }
    }
}
