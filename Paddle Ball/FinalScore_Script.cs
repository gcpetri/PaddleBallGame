using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore_Script : MonoBehaviour
{
    public GameObject other;
    public Text ScoreText;
    public Text highScore;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }
    private void Update()
    {
        ScoreText.text = "Final Score!\n";
        ScoreText.text += other.GetComponent<Ball_Behavior>().score.ToString("0");
        ScoreText.text += "\n\n";
        if (other.GetComponent<Ball_Behavior>().score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", other.GetComponent<Ball_Behavior>().score);
            highScore.text = other.GetComponent<Ball_Behavior>().score.ToString("0");
        }
        ScoreText.text += "High Score: ";
    }
}
