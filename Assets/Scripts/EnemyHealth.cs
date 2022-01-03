using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    private bool isDead = false;
    private bool beenShot = false;
    Collider collider;

    void Start()
    {
        collider = GetComponent<Collider>();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
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
