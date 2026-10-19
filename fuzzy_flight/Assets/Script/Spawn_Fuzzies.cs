using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn_Fuzzies : MonoBehaviour
{
    public GameObject[] objects;
    public Transform SpawnPoint;
    public Rigidbody rigid;
    public float speed = 10f;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Object.Instantiate(objects[UnityEngine.Random.Range(0, objects.Length)], SpawnPoint.position, SpawnPoint.rotation);
    }

    void Update()
    {
        Vector3 Verticalmovement = transform.right * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + Verticalmovement);
    }
}
