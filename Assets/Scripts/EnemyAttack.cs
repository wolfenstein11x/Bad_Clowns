using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;

    Transform target;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().transform;
    }

    public void AttackHitEvent()
    {
        if (target == null) { return; }
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }
}
