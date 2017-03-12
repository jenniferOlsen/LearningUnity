using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{

	// Use this for initialization
	int min;
	int max;
	int guess;
	int maxGuessesAllowed = 5;
	
	public Text currentGuess;
	
	void Start ()
	{
		StartGame ();
	}
	
	void StartGame ()
	{
		max = 1001;
		min = 1;
		NextGuess ();
		
	}
	
	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}
	
	
	void NextGuess ()
	{
		guess = Random.Range (min, max);
		currentGuess.text = guess.ToString ();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed < 0) {
			Application.LoadLevel ("Win");
		}
	}
	
	
}
