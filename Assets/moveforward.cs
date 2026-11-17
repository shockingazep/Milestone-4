using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 1f;
    public int damage = 10;

    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerhealth>().TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}