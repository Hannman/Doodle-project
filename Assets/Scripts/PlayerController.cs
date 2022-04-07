using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float PlayerCurrentPositionY; 

    [SerializeField] private float _speedHorizontal = 8f;
    [SerializeField] private float _speedVertical = 10f;


    private Rigidbody2D _rigidbody;
    private SpriteRenderer _sprite;
    private float _input;
    private float _limitPosition;



    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        GetLimit();

    }



    private void Update()
    {
        PlayerDirection();
        PossitionCheck();
        PlayerCurrentPositionY = transform.position.y;
    }

  

    private void FixedUpdate()
    {
        _input = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_input * _speedHorizontal, _rigidbody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _rigidbody.velocity = Vector2.up * _speedVertical;
        }
    }

    private void PlayerDirection()
    {
        if (_input>0.01f || _input < -0.01f)
        {
            _sprite.flipX = _input < 0;
        }
    }


    private void PossitionCheck()
    {
        if (_rigidbody.position.x > _limitPosition)
        {
            _rigidbody.position = new Vector2(_rigidbody.position.x - (float)GameSettings.screenWidth / 100, _rigidbody.position.y);
        }

        if (_rigidbody.position.x <(-_limitPosition))
        {
            _rigidbody.position = new Vector2 (_rigidbody.position.x + (float)GameSettings.screenWidth / 100, _rigidbody.position.y);
        }
    }

    private void GetLimit()
    {
        _limitPosition = (float)(GameSettings.screenWidth + GameSettings.heroWidth) / 200;
    }

}
