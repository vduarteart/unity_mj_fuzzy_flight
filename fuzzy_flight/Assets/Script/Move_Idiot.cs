using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move_Idiot : MonoBehaviour
{
    public Rigidbody rigid;
    public float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Verticalmovement = transform.right * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + Verticalmovement);
    }
}