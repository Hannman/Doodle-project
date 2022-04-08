using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int score;
    public TextMeshProUGUI scoreText;
    
    private static int  startScore;

    public GameManager()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        startScore = GameSettings.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        CheckLose();
    }

    private void CheckLose()
    {
        if (PlayerController.PlayerCurrentPositionY + 15f < Camera.main.transform.position.y)
        {
            LoadManager.Lose();
        }

    }
    private void CheckWin()
    {
        if (score - 300 >= GameSettings.currentScore)
        {
            GameSettings.currentScore = score;
            GameSettings.level++;
            LoadManager.Win();
        }
    }

    public static void UpdateScore()
    {
        score = (int)(Camera.main.transform.position.y*10) + startScore;

        instance.scoreText.text = $"Score: {score}";
        instance.CheckWin();
    }
}
