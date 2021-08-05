using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

    public int health = 500;

    public Slider healthBar;

    public GameObject deathEffect;

    public bool isInvulnerable = false;

    public GameObject levelWin;

    public GameObject winText;

    public AudioSource bgSound;

    public AudioSource victorySound;

    public void TakeDamage (int damage)
    {
        if (isInvulnerable)
            return;

        healthBar.value = health;

        health -= damage;

        if (health <= 400)
        {
            GetComponent<Animator>().SetBool("Enraged", true);
        }

        if (health <= 0)
        {
            
            //StartCoroutine(Win());
            Die();
            //SceneManager.LoadScene("Victory");
        }
    }

    void Die ()
    {
        //deathEffect.Play();
        Destroy(gameObject);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        levelWin.SetActive(true);
        winText.SetActive(true);
        bgSound.Stop();
        victorySound.Play();

    }

    //IEnumerator Win ()
    //{
        //yield return new WaitForSeconds(0.5f);

        //SceneManager.LoadScene("Victory");
    //}
    

}
