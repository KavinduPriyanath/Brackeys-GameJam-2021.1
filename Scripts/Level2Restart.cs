using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Restart : MonoBehaviour
{
    

    public void Restart()
    {
        SceneManager.LoadScene("Level02");
        
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
