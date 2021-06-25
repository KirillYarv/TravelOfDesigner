using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, LivingThings
{

    private int MaxHealth = 100;
    public int Damage { get; set; }
    public int Heal { get; set; }
    public bool ItIsCanGetDamage { get; set; }
    public bool ItIsCanGetHeal { get; set; }
    public bool ResolutionDiraction;

    private float _intervalTimeDamage;
    private float _intervalTimeHeal;

    private TotalyFanction Dir;
    public GunSprite Gun;
   
    private IPlayerForce _playerForce;

    public HealthSystem _health;
    public HealthBar _healthBar;   

    void Start()
    {  
        _playerForce = GetComponent<Adapter>();

        //_health = gameObject.AddComponent<HealthSystem>();
        _health = new HealthSystem(MaxHealth);

        _healthBar.SetMaxHealth(MaxHealth);

        Dir = GetComponent<TotalyFanction>();
    }

    void LateUpdate()
    {
        _intervalTimeDamage += Time.fixedDeltaTime;
        _intervalTimeHeal += Time.fixedDeltaTime;
       
        if (ItIsCanGetDamage && _intervalTimeDamage >= 2.0f)
        {
             _health.GetDamage(Damage);

             _healthBar.SetHealth(_health.MaxHealth);

            _intervalTimeDamage = 0;
        }


        if (ItIsCanGetHeal && _intervalTimeHeal >= 0.1f)
        {
            _health.GetHeal(Heal);

            _healthBar.SetHealth(_health.MaxHealth);

            _intervalTimeHeal = 0;
            ItIsCanGetHeal = false;
        }


        if (!_health.Death)
        {

            _playerForce.DoPlayer();

            DiractionPlayer();
        }
    }


    

    /// <summary>
 /// /////////////////////////////
 /// </summary>
    private void DiractionPlayer()
    {
        
        if (/*((Gun.Angle <= 90 || Gun.Angle >= -90) && ResolutionDiraction) || ((*/Gun.Angle >= 90 || Gun.Angle <= -90/*) && !ResolutionDiraction)*/ )//если игрок идёт в другую сторону
        {
            ResolutionDiraction = !ResolutionDiraction;
            Dir.DirectionX(transform.localScale);
        }
    }
}
