using UnityEngine;

public class Spawnerr : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        Invoke("SpawnPlayer", 5f);
    }

    void SpawnPlayer()
    {
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
        

    }
}