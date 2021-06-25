using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, LivingThings
{
    private int maxHealthEnemy = 40;
    public bool ItIsCanGetDamage { get; set; }
    public int Damage { get; set; }
    public int Heal { get; set; }
    public bool ItIsCanGetHeal { get; set; }

    private GameObject _EnemyForEnemy;
    private GameObject _Enemy;
    private HealthSystem _healthEnemy;
    private TotalyFanction Dir;
    void Start()
    { 
        _EnemyForEnemy = GameObject.Find("Player");
        _Enemy = GameObject.Find("Enemy");

        //_healthEnemy = gameObject.AddComponent<HealthSystem>();
        _healthEnemy = new HealthSystem(maxHealthEnemy);

        Dir = GetComponent<TotalyFanction>();
    }
    void FixedUpdate()
    {
        ThePursuit();
        //Debug.Log(_healthEnemy.MaxHealth);
        if (ItIsCanGetDamage)
        {
           
            _healthEnemy.GetDamage(Damage);
        }

       
       
    }

    public void ThePursuit/*преследование*/()
    {

        if ( (_EnemyForEnemy.transform.position.x - _Enemy.transform.position.x+4)* (_EnemyForEnemy.transform.position.x - _Enemy.transform.position.x-4) < 0)
        {
           
        }
       
    }
}
