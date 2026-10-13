using System.ComponentModel;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool isJumping = false;
    Rigidbody rb;
    void Start() { rb = GetComponent<Rigidbody>(); }
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {
        if (isJumping)
        {
            isJumping = false;
            rb.linearVelocity = new Vector3(0, 0.7f, 0.7f) * 10;
        }
    }

}
