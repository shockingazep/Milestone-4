using UnityEngine;

public class Enemy2health : MonoBehaviour
{
    public float health = 10f;
    void Update()
    {
        if (health <= 0f)
        {
            Debug.Log("The Enemy has died!");
            Destroy(gameObject);
            FindObjectOfType<WinScreen>().GameWin();
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("The Enemy took " + damage + " damage!");
        Debug.Log("The Enemys health: " + health);
        Debug.Log("YOU WIN!");
    }
}