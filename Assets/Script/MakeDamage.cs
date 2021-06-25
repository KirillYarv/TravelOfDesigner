using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MakeDamage : MonoBehaviour
{
    public string NameTarget;
    public LivingThings ItIsMakeDamage;
    public int damage;

    private void Awake()
    {
        ItIsMakeDamage = GameObject.FindGameObjectWithTag(NameTarget).GetComponent<LivingThings>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == NameTarget)
        {

            ItIsMakeDamage.ItIsCanGetDamage = true;
            ItIsMakeDamage.Damage = damage;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == NameTarget)
        {
            ItIsMakeDamage.ItIsCanGetDamage = false;
        }
    }
}
