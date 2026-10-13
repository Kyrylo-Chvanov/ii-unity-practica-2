using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay(Collider collider)
    {
        Player movement = collider.gameObject.GetComponent<Player>();
        movement.IncreaseDamage();
    }
}
