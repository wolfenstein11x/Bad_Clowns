using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] int healAmount = 30;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().DrinkPotion(healAmount);

            FindObjectOfType<PickupEffects>().PlayPotionEffect();

            Destroy(gameObject);
        }
    }

    
}
