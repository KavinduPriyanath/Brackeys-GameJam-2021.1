using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level6Death : MonoBehaviour
{
    
    public void Restart ()
    {
        SceneManager.LoadScene("Level06");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
