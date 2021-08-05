using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3End : MonoBehaviour
{

    public AudioSource buttonSound;

    public void Level3Ending ()
    {
        buttonSound.Play();
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("Level04");
    }

}
