using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Text dialogueText;
    [SerializeField] List<string> lines;
    [SerializeField] int lettersPerSecond = 10;

    
    int currentLine = -1;
    bool isTyping;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isTyping)
        {
            currentLine++;

            if (currentLine < lines.Count)
            {
                StartCoroutine(TypeLine(lines[currentLine]));
            }

            else
            {
                FindObjectOfType<LevelLoader>().NextScene();
            }
        }
    }

    
    public IEnumerator TypeLine(string line)
    {
        isTyping = true;

        dialogueText.text = "";
        foreach (var letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }

        isTyping = false;
    }
    
}
