using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem potionEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPotionEffect()
    {
        potionEffect.Play();
    }
}
