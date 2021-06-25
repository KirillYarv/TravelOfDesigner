using UnityEngine;
using System;

public class FirstAidKit : Item
{
    public int Heal;
   
    public Player SetHeal;
    public ChestScript chest;
   

    void Start()
    {       
        DropItem();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SetHeal.Heal = Heal;
            SetHeal.ItIsCanGetHeal = true;

            Destroy(gameObject);
        }
      
    }
    

}
