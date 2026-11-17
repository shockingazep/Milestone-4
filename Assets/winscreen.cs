using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void GameWin()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
