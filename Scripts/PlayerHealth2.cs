using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public L10PD playerDeath;

    public int maxHealth = 100;

    public int currentHealth;

    public HealthBar healthBar;

    public ParticleSystem bloodEffect;

    public AudioSource hurtSound;

    void Start ()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Traps")
        {
            TakeDamage(20);
            bloodEffect.Play();
            hurtSound.Play();
        }
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        bloodEffect.Play();
    }

    void Update ()
    {
        if (currentHealth <= 0)
        {
            playerDeath.Redirect();
        }
    }

    
}
