using UnityEngine;

public class projectilemovement : MonoBehaviour
{
    public Vector2 velocity = new Vector2(0, 80);
    public int damage = 10;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerhealth player = collision.GetComponent<playerhealth>();

            if (player != null)
            {
                player.TakeDamage(damage);
                Destroy(gameObject);
                Debug.Log("The Player took " + damage + " damage!");
                Destroy(gameObject);
            }
        }
    }
}
