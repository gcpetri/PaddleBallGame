using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWall_Script : MonoBehaviour
{
    public GameObject finalScore;
    public BoxCollider bxcol;
    public GameObject ball;
    public GameObject scoreText, pauseButton;
    public GameObject home;
    public GameObject startOverSmall;

    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        ball.GetComponent<Ball_Behavior>().score--;
        finalScore.SetActive(true);
        ball.SetActive(false);
        scoreText.SetActive(false);
        pauseButton.SetActive(false);
        home.SetActive(true);
        startOverSmall.SetActive(true);
    }
}
