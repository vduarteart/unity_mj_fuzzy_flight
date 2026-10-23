using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    public float Timer;
    public float CountdownTimer;
    public float EndTimer;
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
                    EndTimer -= Time.deltaTime;

                    if (EndTimer <= 0)
                    {
                        SceneManager.LoadScene("Lose_Lose");
                        Debug.Log("Lose Lose");
                    }
                }
            }
        }

        if (Timer <= 0)
        {
            EndTimer -= Time.deltaTime;

            if (EndTimer <= 0)
            {
                if (player1_health.Health <= 0)
                {
                    SceneManager.LoadScene("Lizard_Win");
                    Debug.Log("Lizard Win");
                }

                if (player2_health.Health <= 0)
                {
                    SceneManager.LoadScene("Monkey_Win");
                    Debug.Log("Monkey Win");
                }

                else
                {
                    SceneManager.LoadScene("Win_Win");
                    Debug.Log("Win Win");
                }
            }
        }
    }
}
