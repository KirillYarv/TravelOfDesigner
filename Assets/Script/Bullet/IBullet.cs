using UnityEngine;

public abstract class IBullet : MonoBehaviour
{
    int i = 1;

    public abstract float Speed { get; set; }
    public abstract int Damage { get; set; }

    public GameObject[] Bullet;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if ()
    //    {

    //    }
    //}
    public void Cloned(Quaternion transfomRotation, Transform _spawnPoint)
    {
        Bullet[i] = Instantiate(Bullet[0], _spawnPoint.position, transfomRotation);
        i++;
    }
    internal void Destroyed()
    {
        for (int ii = 1; ii < Bullet.Length; ii++)
        {
            if (Bullet[ii] == null)
            {
                i = 1;
                break;
            }
            Destroy(Bullet[ii], 1.5f);
        }
    }
}
