using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject PauseCanvas;
    [SerializeField] private GameObject ScoreStripCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePauseMenu() 
    {

        if (PauseCanvas.activeInHierarchy)
        {
            Time.timeScale = 1f;
            PauseCanvas.SetActive(false);
            ScoreStripCanvas.SetActive(true);
        }
        else
        {
            Time.timeScale = 0f;
            PauseCanvas.SetActive(true);
            ScoreStripCanvas.SetActive(false);
        }
    
    }
}
