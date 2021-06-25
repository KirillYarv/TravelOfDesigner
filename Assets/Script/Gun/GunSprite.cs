using UnityEngine;
using System.Threading.Tasks;

public class GunSprite : MonoBehaviour
{

    public float Angle;
    private Vector2 _targetGet;
    private float _time;
    private bool _resolushionDiractionForGun;

    private TotalyFanction _fanctionLibrary;
    public Player _player;
    public IBullet _bullet;
    public Transform SpawnPoint;
    public Rigidbody2D Rbr;
    public Camera Cum;
   


    void Start()
    {
        _fanctionLibrary = GetComponent<TotalyFanction>();
        
    }

    void LateUpdate()
    {
        _time += Time.fixedDeltaTime;
        _targetGet = Cum.ScreenToWorldPoint(Input.mousePosition);
    
        Rbr.MoveRotation(Rotation(transform.position));

        Debug.Log(Rbr.rotation);
        Shoot(transform);


        //DiractionGun(_player, transform);
        
       
    }

    private void DiractionGun(Player player, Transform localScale)
    {
        if (player.ResolutionDiraction && !_resolushionDiractionForGun ||
            !player.ResolutionDiraction && _resolushionDiractionForGun)
        {
            _resolushionDiractionForGun = !_resolushionDiractionForGun;
            _fanctionLibrary.DirectionX(localScale.localScale);
            _fanctionLibrary.DirectionY(localScale.localScale);
        }
    }

    private float Rotation(Vector2 position)
    {
        Vector2 gunRotation = _targetGet - position;

        Angle = Mathf.Atan2(gunRotation.y, gunRotation.x) * Mathf.Rad2Deg - 5f;
        return Angle;
    }

    private void Shoot(Transform rotation)
    {
        if (Input.GetMouseButton(0) && _time >= 0.7f)
        {
            _bullet.Cloned(rotation.rotation, SpawnPoint);
            _time = 0.0f;
        }
    }
}
