using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public GameObject StartText;
    public GameObject Loading;
    public float MercyTimer = 1f;

    void Start()
    {
        StartText.SetActive(true);
        Loading.SetActive(false);
    }

    void Update()
    {
        if (MercyTimer > 0)
        {
            MercyTimer -= Time.deltaTime;
        }

        if (MercyTimer <= 0)
        {
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            {
                StartText.SetActive(false);
                Loading.SetActive(true);
                SceneManager.LoadScene("Scene_1");
            }
        }

    }
}
