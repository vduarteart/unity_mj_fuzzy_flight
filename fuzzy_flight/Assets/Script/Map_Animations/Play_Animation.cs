using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Animation : MonoBehaviour
{
    [SerializeField] private Animator AnimatorController;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sesame"))
        {
            AnimatorController.SetBool("Open_Sesame", true);
            audio.Play();
        }
    }
}