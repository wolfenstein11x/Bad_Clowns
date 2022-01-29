using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 60;

    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerHealth>().TakeDamage(damage);
            player.GetComponent<DisplayDamage>().ShowDamageImpact();
        }
    }
}
