using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void ToGame()
    {
        LoadManager.StartGame();
    }

    public void ToMenu()
    {
        LoadManager.MainMenu();
    }

    public void Exit()
    {
        LoadManager.Exit();
    }
}
