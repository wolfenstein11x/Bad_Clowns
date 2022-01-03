using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    
    [SerializeField] float chaseRange = 5f;
    [SerializeField] float turnSpeed = 5f;
    [SerializeField] float attackOffset = 0.3f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    EnemyHealth health;
    Transform target;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponentInChildren<EnemyHealth>();
        target = FindObjectOfType<PlayerHealth>().transform;
    }

    
    void Update()
    {
        if (health.IsDead())
        {
            enabled = false;
            navMeshAgent.enabled = false;
            return;
        }

        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }
        else if (health.BeenShot())
        {
            isProvoked = true;
        }
        
    }

    private void EngageTarget()
    {
        FaceTarget();

        if (distanceToTarget > navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }

        if (distanceToTarget <= (navMeshAgent.stoppingDistance + attackOffset))
        {
            AttackTarget();
        }
    }

    private void ChaseTarget()
    {
        GetComponentInChildren<Animator>().SetBool("attack", false);
        GetComponentInChildren<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
        GetComponentInChildren<Animator>().SetBool("attack", true);
        //Debug.Log("Clown attack!");
    }


    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed); 
    }
}
