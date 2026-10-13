using Unity.VisualScripting;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Esfera esfera;
    SphereCollider esfera_collider;
    BoxCollider cubo_collider;
    bool collided = false;
    void Start()
    {
        cubo_collider = GetComponent<BoxCollider>();
        esfera_collider = esfera.GetComponent<SphereCollider>();
    }
    void Update()
    {
        if (collided) return;
        float esfera_superficie_x = esfera.transform.position.x + esfera_collider.radius;
        float cubo_superficie = transform.position.x - cubo_collider.size.x / 2;
        if (esfera_superficie_x > cubo_superficie)
        {
            GetComponent<Renderer>().material.color = Color.red;
            collided = true;
        }
    }
}
