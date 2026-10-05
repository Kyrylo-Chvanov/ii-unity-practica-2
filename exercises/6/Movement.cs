using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public double velocity;
    void Start()
    {

    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (!Mathf.Approximately(0, horizontal))
        {
            if (horizontal > 0)
            {
                Debug.Log("Derecha: " + velocity * horizontal);
            }
            else
            {
                Debug.Log("Izquierda: " + velocity * horizontal);
            }
        }
        if (!Mathf.Approximately(0, vertical))
        {
            if (vertical > 0)
            {
                Debug.Log("Arriba: " + velocity * vertical);
            }
            else
            {
                Debug.Log("Abajo: " + velocity * vertical);
            }
        }

    }
}
