using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelFailed : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _line1;
    [SerializeField] private TextMeshProUGUI _line2;
    [SerializeField] private TextMeshProUGUI _buttonLine;

    // Start is called before the first frame update
    void Start()
    {
        _line1.text = $"Level {GameSettings.level} failed...";
        _line2.text = $"Score: {GameSettings.failedScore}/{GameSettings.currentScore + GameSettings.levelDelta}";
        _buttonLine.text = $"REPEAT (LEVEL {GameSettings.level})";

    }

}
