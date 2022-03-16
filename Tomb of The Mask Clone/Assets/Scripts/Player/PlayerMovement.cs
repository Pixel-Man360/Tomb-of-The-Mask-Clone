using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    internal void MovePlayer(Player player)
    {
         Observer.OnPlayerStartedMoving();
          switch (player.directions)
          {
               case Player.InputDirections.left:
                    MoveLeftRight(-1, player.playerData.movementSpeed, player.rigidBody2d);
               break;

               case Player.InputDirections.right:
                    MoveLeftRight(1, player.playerData.movementSpeed, player.rigidBody2d);
               break;

               case Player.InputDirections.up:
                    MoveUpDown(1, player.playerData.movementSpeed, player.rigidBody2d);
               break;

               case Player.InputDirections.down:
                    MoveUpDown(-1, player.playerData.movementSpeed, player.rigidBody2d);
               break;
          }
    }

    void MoveLeftRight(int dir, float speed, Rigidbody2D rb)
    {
          rb.velocity = new Vector2(speed * dir * Time.fixedDeltaTime, 0f);
    }
    

    void MoveUpDown(int dir, float speed, Rigidbody2D rb)
    {
          rb.velocity = new Vector2(0f, speed * dir * Time.fixedDeltaTime);
    }

    
}
