using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public float _speed;
    
    public Movement(float speed)
    {
        this._speed = speed;
    }

    public Vector3 Calculate(float horizontalInput, float verticalInput, float deltaTime) 
    {
        var x = horizontalInput * _speed * deltaTime;
        var y = verticalInput * _speed * deltaTime;
        var movement = new Vector3(x,y,0);
        
        return movement;
    }
}
