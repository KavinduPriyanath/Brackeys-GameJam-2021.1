using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level9Death : MonoBehaviour
{
    
    public void Restart ()
    {
        SceneManager.LoadScene("Level09");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
