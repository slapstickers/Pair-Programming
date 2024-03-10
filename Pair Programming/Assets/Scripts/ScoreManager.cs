using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this; 
    }

    void Start()
    {
        //scoreText.text = "Score: " + score.ToString();
        scoreText.text = $"Score: {score}";
    }

    public void AddPoints(int points)
    {
        score = score + points;
        //scoreText.text = "Score: " + score.ToString();
        scoreText.text = $"Score: {score}";
        //Changed to use String Interpolation for both ScoreText updates lines. Removes additional function call of ToString().
    }
}
