using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void OnPlayerHandler()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Time.timeScale = 1.0f;
    }
    public void OnExitHandler()
    {
        SceneManager.LoadScene(0);
    }
}
