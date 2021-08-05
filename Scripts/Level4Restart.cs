using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Restart : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level04");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
