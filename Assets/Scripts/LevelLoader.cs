using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    Scene activeScene;


    void Start()
    {
        Time.timeScale = 1;
        activeScene = SceneManager.GetActiveScene(); 
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Level_1");
    }
}
