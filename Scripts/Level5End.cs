using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5End : MonoBehaviour
{

    public AudioSource buttonSound;

    public void Level5Ending()
    {
        buttonSound.Play();
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Level06");

    }
}
