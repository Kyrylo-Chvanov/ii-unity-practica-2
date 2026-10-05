using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(moveDirection * speed);
    }
}
