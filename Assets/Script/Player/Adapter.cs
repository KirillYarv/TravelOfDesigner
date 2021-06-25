using UnityEngine;
class Adapter : MonoBehaviour,IPlayerForce
{
    public BetterIdle idle = new BetterIdle();
    public BetterJumping jumping = new BetterJumping();
    public JumpWall jumpWall = new JumpWall();

    public void DoPlayer()
    {
        idle.Idle();
        jumping.Jump();
        jumpWall.JumpOnWall();
    }
}
