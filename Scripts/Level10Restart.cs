using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level10Restart : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level10");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
