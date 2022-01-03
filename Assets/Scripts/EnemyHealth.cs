using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    private bool isDead = false;
    private bool beenShot = false;

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
