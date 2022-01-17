using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 100;
    [SerializeField] HealthBar healthBar;

    private bool isDead = false;
    private bool beenShot = false;
    Collider collider;

    void Start()
    {
        collider = GetComponent<Collider>();
        healthBar.SetMaxHealth(hitPoints);
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        healthBar.SetHealth(hitPoints);
        beenShot = true;

        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) { return; }

        isDead = true;
        GetComponent<Animator>().SetTrigger("die");

        // disable collider so player doesn't have to walk around corpse
        collider.enabled = false;
        
    }

    public bool IsDead()
    {
        return isDead;
    }

    public bool BeenShot()
    {
        return beenShot;
    }
}
