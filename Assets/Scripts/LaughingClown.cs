using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughingClown : MonoBehaviour
{
    [SerializeField] GameObject[] spawners;

    [SerializeField] float spellRange = 15f;
    [SerializeField] float waitTimeMin = 3f;
    [SerializeField] float waitTimeMax = 7f;
    [SerializeField] Transform spawnPoint;

    Animator animator;
    bool isLaughing;
    float distanceToTarget = Mathf.Infinity;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        isLaughing = false;
        animator = GetComponent<Animator>();     
        target = FindObjectOfType<PlayerHealth>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaughing && TargetInRange())
        {
            StartCoroutine(LaughSpell());
        }
    }

    private IEnumerator LaughSpell()
    {
        float waitTime = Random.Range(waitTimeMin, waitTimeMax);

        animator.SetTrigger("laugh");
        isLaughing = true;
        
        yield return new WaitForSeconds(waitTime);
        isLaughing = false;
    }

    public void SpawnClown()
    {
        var spawnerIndex = Random.Range(0, spawners.Length);

        GameObject newClown = Instantiate(spawners[spawnerIndex], spawnPoint.position, spawnPoint.rotation) as GameObject;

        newClown.transform.parent = transform;
    }

    private bool TargetInRange()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        return (distanceToTarget <= spellRange);
    }


}
