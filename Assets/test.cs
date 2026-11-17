using UnityEngine;

public class projectilemovementt : MonoBehaviour
{
    public Vector2 velocity = new Vector2(0, 80);

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}