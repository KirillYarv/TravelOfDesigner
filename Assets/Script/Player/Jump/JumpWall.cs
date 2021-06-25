using System;
using UnityEngine;

internal class JumpWall : StandartComponent
{
    public bool WallLeft { get; set; }
    public bool WallRight { get; set; }

    private float PowerReboundX;
    internal JumpWall()
    {
        WallLeft = false;
        WallRight = false;
        PowerReboundX = 110.0f;
    }

   
    private void WallDrag()
    {
        if (WallLeft || WallRight && Input.GetKey(KeyCode.E))
        {
            Vector2 drag = new Vector2(_body2D.velocity.x, _body2D.drag = 35);
        }
    }

    public void JumpOnWall()
    {
        WallDrag();

        if (WallRight)
        {
            JumpOnWallFunction(_body2D, PowerReboundX, WallRight, -1);
        }
        else if (WallLeft)
        {
            JumpOnWallFunction(_body2D, PowerReboundX, WallLeft, 1);
        }
    }

    private void JumpOnWallFunction(Rigidbody2D _rd, float _powerRebound, bool Wall, int i)
    {
        if (Wall && Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.Space))
        {
            _rd.velocity = new Vector2(Math.Abs(_powerRebound) * i, _powerRebound / 4 );
        }
    }
}