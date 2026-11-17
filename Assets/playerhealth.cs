using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public float health = 10f;
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("The Player has died! You lose!");
            Destroy(gameObject);
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("The Player took " + damage + " damage!");
        Debug.Log("The Player's health: " + health);
    }
}