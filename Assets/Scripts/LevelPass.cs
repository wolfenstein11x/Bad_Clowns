using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPass : MonoBehaviour
{
    // TODO make player enter password to skip levels

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("BossBattle1");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level_4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("FinalBossCutscene");
    }


}
