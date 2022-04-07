using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBlueLogic : PlatformCommonLogic
{
    [SerializeField] private float _positionDelta = 0.1f;
    private bool _currentDirection;
    private float _limit;

    void Awake()
    {
        _currentDirection = Random.value > 0.5f;
        GetLimit();
    }
    private void Update()
    {
        ExistenceEvaluation();
    }

    void FixedUpdate()
    {
        DirrectionCheck();
        NextPossitionCalculation();
    }

    private void DirrectionCheck()
    {
        var position = gameObject.transform.position.x;

        if (position > _limit)
        {
            _currentDirection = false;
            gameObject.transform.position = new Vector2(_limit, gameObject.transform.position.y);
        }
        if (position < (-_limit))
        {
            _currentDirection = true;
            gameObject.transform.position = new Vector2((-_limit), gameObject.transform.position.y);
        }
    }
    private void NextPossitionCalculation()
    {
        Vector2 _nextPosition;
        _nextPosition.y = gameObject.transform.position.y;
        
        if (_currentDirection)
        {
            _nextPosition.x = gameObject.transform.position.x + _positionDelta;
        }
        else
        {
            _nextPosition.x = gameObject.transform.position.x - _positionDelta;
        }
        
        gameObject.transform.position = _nextPosition;
    }

    private void GetLimit()
    {
        _limit = (float)(GameSettings.screenWidth - 128) / 200;
    }


}
