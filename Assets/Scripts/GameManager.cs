using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int score;
    public TextMeshProUGUI scoreText;

    public GameManager()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = GameSettings.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        CheckLose();
    }

    private void CheckLose()
    {
        if (PlayerController.PlayerCurrentPositionY + 5f < Camera.main.transform.position.y)
        {
            LoadManager.Lose();
        }

    }
    private void CheckWin()
    {
        if (score - 1000 >= GameSettings.currentScore)
        {
            GameSettings.currentScore = score;
            GameSettings.level++;
            LoadManager.Win();
        }
    }

    public static void AddPoints(int value)
    {
        score += value;
        instance.scoreText.text = $"Score: {score}";
        instance.CheckWin();
    }
}
