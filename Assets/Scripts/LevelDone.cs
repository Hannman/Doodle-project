using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDone : MonoBehaviour
{
    public TextMeshProUGUI _buttonText;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.text = $"Level {GameSettings.level - 1} completed!";
        _buttonText.text = $"Start level {GameSettings.level}...";
    }

}
