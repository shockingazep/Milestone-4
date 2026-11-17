using UnityEngine;

public class AimAtPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player == null) return;

        Vector2 direction = player.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
