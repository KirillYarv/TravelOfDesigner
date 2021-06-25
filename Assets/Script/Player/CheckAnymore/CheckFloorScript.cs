using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFloorScript : MonoBehaviour
{
    GameObject betterJump;
    // Start is called before the first frame update

    void Start()
    {
        betterJump = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            betterJump.GetComponent<BetterJumping>().Floor = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            betterJump.GetComponent<BetterJumping>().Floor = false;
        }
    }
}
