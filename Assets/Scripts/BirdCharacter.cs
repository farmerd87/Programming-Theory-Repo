using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCharacter : BaseCharacter
{
    private float speed = 2000.0f;
    protected override float Speed 
    {
        get => speed;
        set
        {
            if (value > 2000.0f)
            {
                speed = 2000.0f;
            }
            else
            {
                speed = value;
            }
        }
    }
    protected override float TurnSpeed { get; set; } = 7.0f;
    protected override float JumpForce { get; set; } = 0.5f;

    public override void Move()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        base.Move();
    }

}


