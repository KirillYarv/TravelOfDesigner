using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalyFanction : MonoBehaviour
{
     
    void Start()
    {
        
    }

    public void UpdatePosition(Vector3 _moveInput, float _Speed)
    {
        transform.Translate(   _moveInput * Time.fixedDeltaTime * _Speed); //устанавливает значение для position в Unity
        //т.е. перемещает во время игры 
    }

    public void DirectionX(Vector3 _transformScale)
    {
        
        Vector3 diracScale = _transformScale;
        diracScale.x *= -1;
        transform.localScale = diracScale;
    }
    internal void DirectionY(Vector2 _transformScale)
    {
        Vector3 diracScale = _transformScale;
        diracScale.y *= -1;
        transform.localScale = diracScale;
    }
}
