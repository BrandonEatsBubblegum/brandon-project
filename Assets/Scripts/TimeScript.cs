using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private bool isPaused;
    public TMP_Text pausedText;
    public TMP_Text loadingText;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
                
            }
        }
        if(Input.GetKeyDown("space"))
        {
            // EXERCISE 2.9.2: Start coroutine.
        }
    }

    void PauseGame()
    {
        // EXERCISE 2.9.1: Write code below.

        pausedText.enabled = true;
        pausedText.gameObject.SetActive(true);
    }
    
    void ResumeGame()
    {
        // EXERCISE 2.9.1: Write code below.

        pausedText.gameObject.SetActive(false);
        pausedText.enabled = false;
        
    }

    // EXERCISE 2.9.2: Write coroutine below.
}
