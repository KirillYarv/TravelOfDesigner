using UnityEngine;
using UnityEditor;

public interface LivingThings 
{
     int Damage { get; set; }
     int Heal { get; set; }
     bool ItIsCanGetDamage { get; set; }
     bool ItIsCanGetHeal { get; set; }
}