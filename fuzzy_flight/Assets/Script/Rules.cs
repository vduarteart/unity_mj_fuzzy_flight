using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rules : MonoBehaviour
{

    public float Timer;
    public float CountdownTimer;

    // The time the game is played
    void Update()
    {
        if (CountdownTimer > 0)
        {
            CountdownTimer -= Time.deltaTime;
        }

        if (CountdownTimer <= 0)
        {
            Timer -= Time.deltaTime;
        }

        if (Timer <= 0)
        {
            //End the Game
        }
    }
}
