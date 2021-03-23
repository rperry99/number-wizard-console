using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberWizard : MonoBehaviour {
    int min = 1;
    int max = 1000; 
    int guess = 0;
    
    // Start is called before the first frame update
    void Start() {
        // Generate a guess
        guess = (min + max) / 2;
        
        // Give Instructions to the player
        Debug.Log($"Welcome to number wizard, yo!");
        Debug.Log($"Pick a number between {min} and {max}");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log("Push up for higher, push down for lower, and push enter for correct!");

        // Allow the player to use 1000, normally, the highest guess would be 999.
        max += 1;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            guess = (min + max) / 2;
            Debug.Log($"Of course it's higher... what about {guess}?");
        } else if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            guess = (min + max) / 2;
            Debug.Log($"Lower huh... how about {guess}?");
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log($"Ha! I knew the answer was {guess} all along!");
        }
    }
}
