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
        nextGuess();
    }

    // Update is called once per frame
    void Update() {
    }

    public void nextGuess() {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void onPressHigher() {
        min = guess + 1;
        nextGuess();
    }

    public void onPressLower() {
        max = guess - 1;
        nextGuess();
    }
}
