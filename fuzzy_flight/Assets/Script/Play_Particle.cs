using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Play_Particle : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particleSystem.Play();
            Debug.Log("Suck");
        }
    }
}
