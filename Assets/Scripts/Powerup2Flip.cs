using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


// This stuff is basically the same as Coinflip.cs, if you're confused go look there
public class Powerup2Flip : MonoBehaviour
{
    public TMP_Text buttonText;
    int random;
    string displayText;

    // Start is called before the first frame update
    void Start()
    {
        displayText = "powerup coin 2";
        buttonText.text = displayText;
    }

    // Update is called once per frame
    public void Flip()
    {
        random = Random.Range(0, 2);
        if (random == 1)
        {
            displayText = "Gain Powerup 2";
        }
        else
        {
            displayText = "u suck";
        }

        buttonText.text = displayText;
    }
}
