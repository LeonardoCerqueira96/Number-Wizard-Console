using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min, max, newGuess;
    bool gameOver;
     
    // Use this for initialization
    void Start()
    {
        gameOver = false;

        min = 1;
        max = 1001;
        newGuess = Random.Range(min, max);

        Debug.Log("Welcome to Number Wizard, hooman!");
        Debug.Log("Think of a number between " + min + " and " + (max - 1) + ", hooman.");
        Debug.Log("But don't tell me! Now let's play...");
        Debug.Log("Push Down = lower, Push Up = higher, Push Enter = correct");

        Debug.Log("Is the number you're thinking of " + newGuess + " ?");
    }

    // Update is called once per frame
    void Update()
    {
       if (!gameOver)
       {
            NewGuess();
       }
       else
       {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                min = 1;
                max = 1001;
                newGuess = Random.Range(min, max);
                gameOver = false;
                Debug.Log("Is the number you're thinking of " + newGuess + " ?");
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Application.Quit();
            }
       }
    }

    private void NewGuess()
    {
        if (max <= min)
        {
            Debug.Log("You cheater! How dare you!? We're through!");
            Debug.Log("Would you like to play again? (y/n)");
            gameOver = true;
            return;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = newGuess;
            newGuess = (max + min) / 2;
            Debug.Log("Is the number you're thinking of " + newGuess + " ?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = newGuess;
            newGuess = (max + min) / 2;
            Debug.Log("Is the number you're thinking of " + newGuess + " ?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Hah! I've won once again! You'll never beat me, hooman!");
            Debug.Log("Would you like to play again? (y/n)");
            gameOver = true;
        }
    }
}
