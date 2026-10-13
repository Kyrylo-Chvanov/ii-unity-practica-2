using UnityEngine;

public class CollisionRed : MonoBehaviour
{
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.body.name);
        if (collision.body.name == "Capsule")
        {
            renderer.material.color = Color.red;
        }
    }
}
