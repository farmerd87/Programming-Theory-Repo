using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCharacter : BaseCharacter
{
    protected override float Speed { get; set; } = 2000.0f;
    protected override float TurnSpeed { get; set; } = 7.0f;
    protected override float JumpForce { get; set; } = 20.0f;


}
