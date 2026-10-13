using UnityEngine;

public class Esfera : MonoBehaviour
{
    public GameObject target;
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - transform.position;
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
