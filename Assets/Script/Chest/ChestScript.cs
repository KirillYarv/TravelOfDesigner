using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ChestScript : StandartComponent
{
    private GameObject _player;
    public Transform Spawn;
    public Item _item;
    
    internal bool _ItIsOpen = false;

    void Start()
    {
        _player = GameObject.Find("Player");   
    }

    void FixedUpdate()
    {
        SeachPlayer();
    }
    private void SeachPlayer()
    {
        if (!_ItIsOpen&&(_player.transform.position.x - gameObject.transform.position.x + 2) * (_player.transform.position.x - gameObject.transform.position.x - 2) < 0)
        {
            Debug.Log((_player.transform.position.x - gameObject.transform.position.x + 2) * (_player.transform.position.x - gameObject.transform.position.x - 2));
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _item.AnyoneItem(Spawn, _item);

                _animation.SetBool("_ItIsOpen", true);

                _ItIsOpen = true;
            }
            
        }
    }
   
}
