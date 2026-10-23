using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plane1_Animation : MonoBehaviour
{
    public GameObject Plane1Max;
    public GameObject Plane1Mid;
    public GameObject Plane1Low;
    public GameObject Plane1Life;
    public GameObject Plane1;

    void Start()
    {
        Plane1Life = Instantiate(Plane1Max, transform.position, transform.rotation) as GameObject;
        Plane1Life.transform.parent = transform;
    }

    void Update()
    {
        Player_Health player1_health = Plane1.GetComponent<Player_Health>();

        if (player1_health.Health == 2)
        {
            GameObject ChangePlane = Instantiate(Plane1Mid, transform.position, transform.rotation) as GameObject;
            Destroy(Plane1Life);
            ChangePlane.transform.parent = transform;
            Plane1Life = ChangePlane;
        }

        if (player1_health.Health == 1)
        {
            GameObject ChangePlane = Instantiate(Plane1Low, transform.position, transform.rotation) as GameObject;
            Destroy(Plane1Life);
            ChangePlane.transform.parent = transform;
            Plane1Life = ChangePlane;
        }

        if (player1_health.Health == 0)
        {
            Destroy(Plane1Life);
        }
    }
}
