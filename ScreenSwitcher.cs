using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    public bool gameTrue = false;
    public float timeDelay = 3f;
    private float elapsedTime = 0f;

    private void Update()
    {
        if (gameTrue)
        {
            elapsedTime += 0.1f;
            if (elapsedTime > timeDelay)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
    public void GotoGameScene()
    {
        gameTrue = true;
        Time.timeScale = 1;
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
