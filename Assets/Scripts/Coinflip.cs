using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// The TMPro library is what I'm using to change the button texts. Script won't work without it.

public class Coinflip : MonoBehaviour
// This is the first testing button. We can basically copy paste this and modify it (like I did for the two powerup buttons) when we need to.
{
    // The TMP_Text and GameObject variables have been set within the Unity editor. To change them select the NormalButton object in the main 
    // Unity window, find the script component in the inspector, and drag a different object in.
    public TMP_Text buttonText;
    public GameObject scoreTracker;

    // Other helper stuff
    int random, score;
    string displayText;

    // Start is called before the first frame update
    void Start()
    {
        displayText = "regular coin";
        buttonText.text = displayText;
    }

    // Update is called once per frame
    public void Flip()
    {
        // Yay coinflipping logic
        random = Random.Range(0, 2);
        if (random == 1)
        {
            displayText = "Heads";
        } else
        {
            displayText = "Tails";
        }

        // buttonText.text changes our text output.
        buttonText.text = displayText;

        // This calls the UpdateScore function for the scoretracker to update the score
        // (hence the name updatescore) (these comments are useful i promise)
        scoreTracker.GetComponent<ScoreTracker>().UpdateScore(random);
    }
}
