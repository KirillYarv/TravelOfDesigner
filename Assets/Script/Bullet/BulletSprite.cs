using UnityEngine;

public class BulletSprite : IBullet
{
    public override float Speed { get; set; }
    public override int Damage { get; set; }

    private TotalyFanction Dir;

    void Start()
    {
        Speed = 15.0f;
        Damage = 20;
        Dir = GetComponent<TotalyFanction>();

        
    }

    public void FixedUpdate()
    {
        Dir.UpdatePosition(Vector2.right, Speed );

        Destroyed();

    }

    

    
}
