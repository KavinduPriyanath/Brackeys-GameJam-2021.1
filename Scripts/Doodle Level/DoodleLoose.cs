using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoodleLoose : MonoBehaviour
{

    public AudioSource levelLoose;
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            levelLoose.Play();
            StartCoroutine(LoadLevel());
            
        }
    }

    IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(0.2f);
        
        SceneManager.LoadScene("Level06Death");
        
    }


}
