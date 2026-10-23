using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plane2_Animation : MonoBehaviour
{
    public GameObject Plane2Max;
    public GameObject Plane2Mid;
    public GameObject Plane2Low;
    public GameObject Plane2Life;
    public GameObject Plane2;

    void Start()
    {
        Plane2Life = Instantiate(Plane2Max, transform.position, transform.rotation) as GameObject;
        Plane2Life.transform.parent = transform;
    }

    void Update()
    {
        Player_Health player2_health = Plane2.GetComponent<Player_Health>();

        if (player2_health.Health == 2)
        {
            GameObject ChangePlane = Instantiate(Plane2Mid, transform.position, transform.rotation) as GameObject;
            Destroy(Plane2Life);
            ChangePlane.transform.parent = transform;
            Plane2Life = ChangePlane;
        }

        if (player2_health.Health == 1)
        {
            GameObject ChangePlane = Instantiate(Plane2Low, transform.position, transform.rotation) as GameObject;
            Destroy(Plane2Life);
            ChangePlane.transform.parent = transform;
            Plane2Life = ChangePlane;
        }

        if (player2_health.Health == 0)
        {
            Destroy(Plane2Life);
        }
    }
}