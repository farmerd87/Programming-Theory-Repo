using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCharacter : BaseCharacter
{
    protected override float Speed { get; set; } = 30000.0f;
    protected override float TurnSpeed { get; set; } = 0.2f;
    protected override float JumpForce { get; set; } = 150.0f;
}
