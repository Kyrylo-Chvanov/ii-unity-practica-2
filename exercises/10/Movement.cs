using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {

    }

    void Update()
    {
        Vector3 moveDirection = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
