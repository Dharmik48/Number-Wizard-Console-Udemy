using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int max, min, guess;
  // Start is called before the first frame update
  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = (max + min) / 2;
    Debug.Log("Welcome to the GAME!");
    Debug.Log("Pick a number: ");
    Debug.Log("Lowest num you can pick is: " + min);
    Debug.Log("Highest num you can pick is: " + max);
    Debug.Log("Is your number higher or lower than " + guess);
    Debug.Log("UP arrow - higher, DOWN arrow - lower, Enter - Correct");
    max = max + 1;
    Debug.Log(guess);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      min = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      max = guess;
      NextGuess();
    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("I am the BEST... well kinda a😅");
      StartGame();
    }
  }

  void NextGuess()
  {
    guess = (max + min) / 2;
    Debug.Log("Is this it?" + guess);
  }

}
