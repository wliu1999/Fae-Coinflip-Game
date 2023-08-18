using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// The scoretracker script tracks the score. what else do i write here lol

public class ScoreTracker : MonoBehaviour
{
    public TMP_Text buttonText;
    int totalScore;
    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
        buttonText.text = "Score: ";
    }

    // Update is called once per frame
    public void UpdateScore(int score)
    {
        totalScore = totalScore + score;
        buttonText.text = "Score: " + totalScore.ToString();
    }
}
