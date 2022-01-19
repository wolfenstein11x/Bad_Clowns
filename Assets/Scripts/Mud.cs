using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Mud : MonoBehaviour
{
    [SerializeField] float slowDownFactor = 0.1f;

    RigidbodyFirstPersonController fpsController;
    //float forwardSpeedOriginal;
    //float backwardSpeedOriginal;
    //float strafeSpeedOriginal;

    void Start()
    {
        fpsController = FindObjectOfType<RigidbodyFirstPersonController>();
        //forwardSpeedOriginal = fpsController.movementSettings.ForwardSpeed;
        //backwardSpeedOriginal = fpsController.movementSettings.BackwardSpeed;
        //strafeSpeedOriginal = fpsController.movementSettings.StrafeSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fpsController.movementSettings.ForwardSpeed *= slowDownFactor;
            fpsController.movementSettings.BackwardSpeed *= slowDownFactor;
            fpsController.movementSettings.StrafeSpeed *= slowDownFactor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fpsController.movementSettings.ForwardSpeed *= (1 / slowDownFactor);
            fpsController.movementSettings.BackwardSpeed *= (1 / slowDownFactor);
            fpsController.movementSettings.StrafeSpeed *= (1 / slowDownFactor);
        }
    }
}
