using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Tie_Win_Audio : MonoBehaviour
{
    public float Timer;
    public float ReturnTimer;
    public GameObject Audio;
    public GameObject Return;
    public GameObject Loading;

    void Start()
    {
        Audio.SetActive(false);
        Return.SetActive(false);
        Loading.SetActive(false);
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        ReturnTimer -= Time.deltaTime;

        if (Timer <= 0)
        {
            Audio.SetActive(true);
        }

        if (ReturnTimer <= 0)
        {
            Return.SetActive(true);

            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            {
                Return.SetActive(false);
                Loading.SetActive(true);
                SceneManager.LoadScene("Main_Menu");
            }
        }
    }
}
