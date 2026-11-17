using UnityEngine;

public class projectilemovement2 : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-100, 0);
    public int damage = 100;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy2health enemy = collision.GetComponent<Enemy2health>();

        if (enemy != null)
        {
            enemy.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
