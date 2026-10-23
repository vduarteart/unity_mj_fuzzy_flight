using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILL : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KILL"))
        {
            Destroy(gameObject);
        }
    }
}