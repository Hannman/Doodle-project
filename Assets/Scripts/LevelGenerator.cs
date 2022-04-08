using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _prefubs;
    private float _minY = 0.6f;
    private float _maxY = 1.2f;
    private float _limit;
    private float _greenBlueRatio = 0.7f;
    private float _platformBrownChance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        _limit = (float)(GameSettings.screenWidth - 128) / 200;

        Vector2 _newPlatformPosition = new Vector2();
        for (int i = 0; i < 200; i++)
        {
            _newPlatformPosition.y += Random.Range(_minY, _maxY);
            _newPlatformPosition.x = Random.Range((-_limit), _limit);
           
            Instantiate(_prefubs[Random.value > _greenBlueRatio ? 1 : 0], _newPlatformPosition, Quaternion.identity);
            if (Random.value < _platformBrownChance)
            {
                var _platformBrownPosition = new Vector2(Random.Range((-_limit), _limit), _newPlatformPosition.y + 0.3f);
                Instantiate(_prefubs[2], _platformBrownPosition, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
