using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class runnermenu : MonoBehaviour
{
    public void OnPlayHandler()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void OnExitHandler()
    {
        Application.Quit();
    }
}
