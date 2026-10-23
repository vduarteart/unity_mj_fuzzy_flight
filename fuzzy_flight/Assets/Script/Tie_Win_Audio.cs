using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tie_Win_Audio : MonoBehaviour
{
    public float Timer;
    public GameObject Audio;

    void Start()
    {
        Audio.SetActive(false);
    }

    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            Audio.SetActive(true);
        }
    }
}
