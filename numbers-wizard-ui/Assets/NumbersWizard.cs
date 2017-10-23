using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NumbersWizard : MonoBehaviour {

    int min;
    int max;
    int guess;
    int maxGuessesAllowed = 10;

    public Text guessText;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    private void StartGame()
    {
		min = 1;
		max = 1000;
        NextGuess();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower () {
        max = guess;
        NextGuess();
    }

    void NextGuess() {

        //guess = (min + max) / 2;
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

        maxGuessesAllowed -= 1;

        if (maxGuessesAllowed <= 0) {
            SceneManager.LoadScene("Win");
        }
	}
}
