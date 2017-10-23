using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelManager = FindObjectOfType<LevelManager>();

        print("Trigger");
        levelManager.LoadLevel("Loose Screen");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
