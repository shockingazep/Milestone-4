using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}