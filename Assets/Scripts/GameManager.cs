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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddPoints(int value) 
    {
        score += value;
        instance.scoreText.text = $"Score: {score}";
    }
}
