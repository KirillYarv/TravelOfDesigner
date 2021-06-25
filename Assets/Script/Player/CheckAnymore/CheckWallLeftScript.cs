using UnityEngine;

public class CheckWallLeftScript : MonoBehaviour
{
    GameObject jumpWall;

    void Start()
    {
        jumpWall = gameObject.transform.parent.gameObject;
    }


    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "WallLeft")
        {
            jumpWall.GetComponent<JumpWall>().WallLeft = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "WallLeft")
        {
            jumpWall.GetComponent<JumpWall>().WallLeft = false;
        }
    }
}