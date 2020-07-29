using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObject_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject resume;
    public GameObject startOver;
    public GameObject home;
    public GameObject startOverSmall;
    public GameObject home2;
    void Start()
    {
        resume.SetActive(false);
        startOver.SetActive(false);
        home.SetActive(false);
        startOverSmall.SetActive(false);
        home2.SetActive(false);
    }

    public void ItsClicked()
    {
        resume.SetActive(true);
        startOver.SetActive(true);
        home2.SetActive(true);
    }

    public void ItsRestarted()
    {
        SceneManager.LoadSceneAsync(1);
        resume.SetActive(false);
        startOver.SetActive(false);
        Time.timeScale = 1;
    }

    public void ItsPaused()
    {
        Time.timeScale = 0;
    }

    public void ItsUnPaused()
    {
        Time.timeScale = 1;
        resume.SetActive(false);
        startOver.SetActive(false);
        home2.SetActive(false);
    }

    public void GoHome()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
}
