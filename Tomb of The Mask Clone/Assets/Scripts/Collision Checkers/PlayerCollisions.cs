using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : Collisions
{
    protected override void OnCollisionEffects(Collision2D other)
    {
        ICollectible collectible = other.gameObject.GetComponent<ICollectible>();
        IKiller killer = other.gameObject.GetComponent<IKiller>();

        if(collectible != null)
        {
            SoundManage.instance.PlaySound("Collect");
            collectible.Collect();
        }

        if(killer != null) 
        {
            SoundManage.instance.PlaySound("Game Over");
            killer.KillPlayer();
        }
    }

    protected override void OffCollisionEffects(Collision2D other){}
}
