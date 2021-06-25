using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public int MaxHealth { get; set; }
    public bool Death { get; set; }

    public HealthSystem(int yourHealth)
    {
        MaxHealth = yourHealth;
        Death = false;
    }

    public void GetHeal(int heal)
    {
        if (MaxHealth != 100 ) {
            MaxHealth += heal;
            if (MaxHealth > 100)
            {
                MaxHealth = 100;
            }
        }
    }

    public void GetDamage(int damage)
    {
        MaxHealth -= damage;

        if (MaxHealth <= 0)
        {
            Death = true;
            MaxHealth = 0;
        }
    }
}