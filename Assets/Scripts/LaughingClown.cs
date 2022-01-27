using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughingClown : MonoBehaviour
{
    [SerializeField] float waitTimeMin = 3f;
    [SerializeField] float waitTimeMax = 7f;

    Animator animator;
    bool isLaughing;

    // Start is called before the first frame update
    void Start()
    {
        isLaughing = false;
        animator = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaughing)
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


}
