using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] Canvas levelCompleteCanvas;

    void Start()
    {
        levelCompleteCanvas.enabled = false;
    }

    
    private void HandleWin()
    {
        levelCompleteCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        HandleWin();
    }
}
