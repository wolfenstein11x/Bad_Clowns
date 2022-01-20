using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 100;
    [SerializeField] HealthBar healthBar;
    [SerializeField] FinishPoint finishPoint;

    // needed due to health bar increment resolution not fine enough
    [SerializeField] int minHealth = 126;

    private bool isDead = false;
    private bool beenShot = false;
    Collider collider;

    void Start()
    {
        finishPoint.gameObject.SetActive(false);
        collider = GetComponent<Collider>();
        healthBar.SetMaxHealth(hitPoints);
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        healthBar.SetHealth(hitPoints);
        beenShot = true;

        if (hitPoints <= minHealth)
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

        // enable finish point now that boss is defeated
        finishPoint.gameObject.SetActive(true);
        
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
