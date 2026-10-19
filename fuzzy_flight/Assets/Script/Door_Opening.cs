using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Door_Opening : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 5)
        {
            Destroy(gameObject);
        }
    }
}