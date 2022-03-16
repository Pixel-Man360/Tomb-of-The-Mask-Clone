using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorCollisions : Collisions
{
    protected override void OnCollisionEffects(Collision2D other)
    {
        SoundManage.instance.PlaySound("Level Over");
        Observer.OnLevelOver();
    }
}