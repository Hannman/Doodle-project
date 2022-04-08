using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadManager 
{

    public static void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public static void Win()
    {
        SceneManager.LoadScene("LevelDone");
    }

    public static void Lose()
    {
        GameSettings.currentScore = 0;
        SceneManager.LoadScene("Lose");
    }

    public static void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
