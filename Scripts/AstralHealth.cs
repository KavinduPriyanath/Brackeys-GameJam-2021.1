using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstralHealth : MonoBehaviour
{

    public int maxHealth = 100;

    public int currentHealth;

    public HealthBar healthBar;

    public ParticleSystem bloodEffect;

    public AudioSource hurtSound;

    public L4PD astralDeath;

    void Start ()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Traps")
        {
            TakeDamage(10);
            bloodEffect.Play();
            hurtSound.Play();
        }
    }

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Asteroids")
        {
            TakeDamage(30);
            bloodEffect.Play();
            hurtSound.Play();
        }
    }

    void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void Update ()
    {
        if (currentHealth <= 0)
        {
            astralDeath.Redirect();
        }
    }

}
