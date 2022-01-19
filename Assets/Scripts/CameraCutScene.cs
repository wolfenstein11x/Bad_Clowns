using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraCutScene : MonoBehaviour
{
    Scene activeScene;

    void Start()
    {
        Time.timeScale = 1;
        activeScene = SceneManager.GetActiveScene(); 
    }

    public void NextScene()
    {
        SceneManager.LoadScene(activeScene.buildIndex + 1);
    }
}
