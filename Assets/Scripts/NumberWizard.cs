using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	// creating a couple of number variables
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
	
		// start the game function
		StartGame ();
	}
	
	void StartGame () {
		// setting the value of the variables
		max = 1000;
		min = 1;
		guess = 500;
		
		// basic printing of strings to console
		print ("===========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		//  printing the variables to the console
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		// first guess by the computer
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");

		// fixes the rounding problem of stopping at 999
		max = max +1;
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update () {
	
		// Registering when a player taps certain keys
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// setting the min to 500
			min = guess;
			NextGuess();
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
			} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!"); 
			StartGame();
		}
			
	}
}
