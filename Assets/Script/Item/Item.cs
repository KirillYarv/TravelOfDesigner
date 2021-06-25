using UnityEngine;
using System;

public abstract class Item : MonoBehaviour
{ 
    private float moveY = 4;

    public Rigidbody2D itemRb;
    public Item item;


    private void Start()
    {
    }
    public void AnyoneItem(Transform spawn, Item one)
    {
        item = Instantiate(one, spawn.transform.position, Quaternion.identity);
        
    }
    public void DropItem()

    {
        itemRb.velocity = new Vector2(moveY, Math.Abs(moveY));
        itemRb.drag = 1;

    }
    
}