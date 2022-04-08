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
    private Vector2 _newPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        _limit = (float)(GameSettings.screenWidth - 128) / 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (_newPosition.y - 10f < Camera.main.transform.position.y)
        {
            GeneratePlatforms();
        }
    }

    private void GeneratePlatforms()
    {
        for (int i = 0; i < 20; i++)
        {
            _newPosition.y += Random.Range(_minY, _maxY);
            _newPosition.x = Random.Range((-_limit), _limit);

            //основные платформы
            Instantiate(_prefubs[Random.value > _greenBlueRatio ? 1 : 0], _newPosition, Quaternion.identity);

            //дополнительные (разрушаемые)
            if (Random.value < _platformBrownChance)
            {
                var _platformBrownPosition = new Vector2(Random.Range((-_limit), _limit), _newPosition.y + 0.3f);
                Instantiate(_prefubs[2], _platformBrownPosition, Quaternion.identity);
            }
        }
    }
}
