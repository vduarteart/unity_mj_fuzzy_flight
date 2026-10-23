using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rules : MonoBehaviour
{

    public float Timer;
    public float CountdownTimer;
    public GameObject Plane1, Plane2; 

    // The time the game is played
    void Update()
    {
        Player_Health player1_health = Plane1.GetComponent<Player_Health>();
        Player_Health player2_health = Plane2.GetComponent<Player_Health>();

        if (CountdownTimer > 0)
        {
            CountdownTimer -= Time.deltaTime;
        }

        if (CountdownTimer <= 0)
        {
            Timer -= Time.deltaTime;
            if (player1_health.Health == 0)
            {
                if (player2_health.Health == 0)
                {
                    //End the game
                    Debug.Log("Kus");
                }
            }
        }

        if (Timer <= 0)
        {
            //End the Game
        }
    }
}
