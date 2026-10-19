using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rules : MonoBehaviour
{

    public float Timer;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            //End the Game
        }
    }
}
