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
        SceneManager.LoadScene("MainMenu");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadCredits()
    {
        Debug.Log("credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
