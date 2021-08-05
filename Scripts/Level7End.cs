using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7End : MonoBehaviour
{

    public AudioSource buttonSound;

    public void Level7Ending()
    {
        
        buttonSound.Play();
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level09");
    }
}
