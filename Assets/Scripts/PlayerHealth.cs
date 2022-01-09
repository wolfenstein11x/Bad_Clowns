using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 100;
    [SerializeField] HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(hitPoints);
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        healthBar.SetHealth(hitPoints);

        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

    public void DrinkPotion(int health)
    {
        hitPoints += health;
        healthBar.SetHealth(hitPoints);
    }
}
