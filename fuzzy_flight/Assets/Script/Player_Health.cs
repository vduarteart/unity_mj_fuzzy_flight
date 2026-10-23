using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Health : MonoBehaviour
{
    public int Health;
    public int MaxHealth = 3;
    public int invuln_frames;

    void Start()
    {
        Health = MaxHealth;
    }

    void FixedUpdate()
    {
        if (invuln_frames > 0)
        {
            invuln_frames -= 1;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (invuln_frames == 0)
        {
            if (other.gameObject.tag == "Fuzzy")
            {
                Health -= 1;
                invuln_frames += 60;

                if (Health <= 0)
                {
                    //Destroy(gameObject);
                    Debug.Log("Plane Dead");
                }
            }
        }
    }
}