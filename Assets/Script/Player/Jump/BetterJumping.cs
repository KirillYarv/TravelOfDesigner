using JetBrains.Annotations;
using UnityEngine;




internal class BetterJumping : StandartComponent, IBetterJumping
{
    private float StartJump;
    public bool Floor { get; set; }
    private int _gravity;

    internal BetterJumping()
    {
        StartJump = 26f;
        Floor = false;
        _gravity = 2;
    }
   
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Floor)
        {

            _body2D.velocity = new Vector2(_body2D.velocity.x, StartJump);
            Vector2 jumpInput = Vector2.up * StartJump;

            _body2D.AddForce(Vector2.up * StartJump, ForceMode2D.Force);
            //_dir.UpdatePosition(jumpInput, StartJump);

            _animation.SetBool("IsJumping", true);
        }
        IsJump();
        SetGravity();
    }
    
    private void IsJump()
    {
        
        _animation.SetBool("IsJumping", !Floor);
    }

    private void SetGravity()
    {
        if (Floor)
        {
            _body2D.gravityScale = 0;
        }
        else
        {
            _body2D.gravityScale = _gravity;

            if (Input.GetKeyDown(KeyCode.Space) && Floor)
            {
                _body2D.gravityScale = _gravity * StartJump;
            }
            else if (_body2D.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                _body2D.gravityScale = _gravity * (StartJump / 2);
            }

        }
    }

   
}