using UnityEngine;

public class ColorZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Renderer renderer = collider.gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.red;
    }

    void OnTriggerExit(Collider collider)
    {
        Renderer renderer = collider.gameObject.GetComponent<Renderer>();
        renderer.material.color = Color.blue;
    }
}
