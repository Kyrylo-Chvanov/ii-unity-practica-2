using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    float damage = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection.Normalize();
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }

    public void IncreaseDamage()
    {
        damage += 5;
        Debug.Log($"Damage is now {damage}");
    }
}
