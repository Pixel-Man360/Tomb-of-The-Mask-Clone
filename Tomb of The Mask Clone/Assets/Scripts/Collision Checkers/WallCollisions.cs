using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisions : Collisions
{

    protected override void OnCollisionEffects(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SoundManage.instance.PlaySound("Stop");
            Observer.OnPlayerTouchWalls(true);
        }
    }

    protected override void OffCollisionEffects(Collision2D other)
    {
        Observer.OnPlayerTouchWalls(false);
        
    }
}
