using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EntranceToNewScene : MonoBehaviour
{
    [SerializeField] Canvas loadingTextCanvas;

    Scene activeScene;

    // Start is called before the first frame update
    void Start()
    {
        loadingTextCanvas.enabled = false;
        activeScene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            loadingTextCanvas.enabled = true;
            SceneManager.LoadScene(activeScene.buildIndex + 1);
        }
    }


}
