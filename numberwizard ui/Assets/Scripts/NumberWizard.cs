using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] private int min, max;
    [SerializeField] private TextMeshProUGUI guessText;
    int guess;
    
    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        NextGuess();
    }

    // Update is called once per frame
    void Update() {
    }

    public void NextGuess() {
        if (min > max)
            min = max;

        if (max <= min)
            min = guess;
        
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }
}
