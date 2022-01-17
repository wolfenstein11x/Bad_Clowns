using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] int damage1 = 40;
    [SerializeField] int damage2 = 80;

    Transform target;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>().transform;
    }

    public void AttackHitEvent1()
    {
        if (target == null) { return; }
        target.GetComponent<PlayerHealth>().TakeDamage(damage1);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

    public void AttackHitEvent2()
    {
        if (target == null) { return; }
        target.GetComponent<PlayerHealth>().TakeDamage(damage2);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }
}
