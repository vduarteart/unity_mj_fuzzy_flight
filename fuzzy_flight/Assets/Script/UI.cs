using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UI : MonoBehaviour
{
    public GameObject StartGame;
    public GameObject Finish;
    public GameObject Monkey_Indicator;
    public GameObject Lizard_Indicator;
    public GameObject Monkey_Life_1;
    public GameObject Monkey_Life_2;
    public GameObject Monkey_Life_3;
    public GameObject Lizard_Life_1;
    public GameObject Lizard_Life_2;
    public GameObject Lizard_Life_3;
    public GameObject GameRules;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject BGM; //Kill me for this

    public float Timer;
    public float CountdownTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartGame.SetActive(false);
        Finish.SetActive(false);
        BGM.SetActive(false);
    }

    // THE WORST CODE I HAVE EVER WRITTEN. DO NOT LOOK AT THIS. NSFW, GORE, etc.
    void Update()
    {
        Player_Health player1_health = Plane1.GetComponent<Player_Health>();
        Player_Health player2_health = Plane2.GetComponent<Player_Health>();

        if (CountdownTimer > 0)
        {
            CountdownTimer -= Time.deltaTime;

            if (CountdownTimer <= 1.2 && CountdownTimer >= 0)
            {
                StartGame.SetActive(true);
            }

            else
            {
                StartGame.SetActive(false);
            }

            if (CountdownTimer <= 1.5)
            {
                Monkey_Indicator.SetActive(false);
                Lizard_Indicator.SetActive(false);
            }
        }

        if (CountdownTimer <= 0)
        {
            Timer -= Time.deltaTime;
            BGM.SetActive(true);
        }

        if (Timer <= 0 )
        {
            Finish.SetActive(true);
        }

        if (player1_health.Health == 2)
        {
            Monkey_Life_3.SetActive(false);
        }

        if (player1_health.Health == 1)
        {
            Monkey_Life_2.SetActive(false);
        }

        if (player1_health.Health == 0)
        {
            Monkey_Life_1.SetActive(false);
        }

        if (player2_health.Health == 2)
        {
            Lizard_Life_3.SetActive(false);
        }

        if (player2_health.Health == 1)
        {
            Lizard_Life_2.SetActive(false);
        }

        if (player2_health.Health == 0)
        {
            Lizard_Life_1.SetActive(false);
        }

        if (player1_health.Health <= 0 && player2_health.Health <= 0)
        {
            Finish.SetActive(true);
        }
    }
}
