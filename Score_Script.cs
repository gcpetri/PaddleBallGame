using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    public GameObject other;
    public Text ScoreText;

    
    private void Start()
    {
        ScoreText.text = other.GetComponent<Ball_Behavior>().score.ToString("0");
    }
    
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = other.GetComponent<Ball_Behavior>().score.ToString("0");
    }
}
