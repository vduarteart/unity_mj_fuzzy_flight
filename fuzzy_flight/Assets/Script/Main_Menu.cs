using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            SceneManager.LoadScene("Scene_1");
        }
    }
}
