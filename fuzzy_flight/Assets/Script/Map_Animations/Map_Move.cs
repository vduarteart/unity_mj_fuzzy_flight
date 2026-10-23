using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;


public class Map_Move : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed = 0.2f;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 Verticalmovement = transform.right * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + Verticalmovement);
    }
}
