using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Movement : MonoBehaviour
{
    public Vector3 delta;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position += delta;
        }
    }
}
