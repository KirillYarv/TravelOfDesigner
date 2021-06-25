using System;
using UnityEngine;

internal class BetterIdle : StandartComponent,IBetterIdle
{
    private float Speed;

    private float _horizontal; 

    private float MaxSpeed;

    private float SlowDown;

    public JumpWall _jumpWall;

    private void Start()
    {
        _jumpWall = GetComponent<JumpWall>();
    }
    public BetterIdle()
    {
        Speed = 20;
        MaxSpeed = 6;
        SlowDown = 6;
    }
   
    public void Idle()
    {
        if (!_jumpWall.WallLeft || !_jumpWall.WallRight)
        {
            _horizontal = Input.GetAxisRaw("Horizontal");
            Vector2 moveInput = new Vector2(_horizontal, 0f);

            _body2D.AddForce(Vector2.right * moveInput.x * Speed);

            FixAddForceSlowDown();
            FixAddForseMaxSpeed();
            AnimationIdle();
        }
        
    }

    private void FixAddForceSlowDown()
    {
        if (_body2D.drag <= 0.5f) //Drag - замедляет 
        {
            _body2D.drag = SlowDown;
        }
        else
        {
            _body2D.drag = 0;
        }

    }

    private void FixAddForseMaxSpeed()
    {
        if (Math.Abs(_body2D.velocity.x) >= MaxSpeed)
        {
            _body2D.velocity = new Vector2(Math.Sign(_body2D.velocity.x) * MaxSpeed, _body2D.velocity.y);
        }
    }
    private void AnimationIdle()
    {
        _animation.SetFloat("IsItMovement", Math.Abs(_horizontal));
    }
}
