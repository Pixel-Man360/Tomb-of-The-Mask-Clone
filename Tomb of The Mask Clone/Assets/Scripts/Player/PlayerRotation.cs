using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    internal void RotatePlayer(Player player)
    {
        
       switch (player.directions)
       {
           case Player.InputDirections.left:
                RotationAngleHandler(Quaternion.Euler(0, 0, -90), player.playerData.rotationSpeed);
           break;

           case Player.InputDirections.right:
                RotationAngleHandler(Quaternion.Euler(0, 0, 90), player.playerData.rotationSpeed);
           break;

           case Player.InputDirections.up:
                RotationAngleHandler(Quaternion.Euler(0, 0, 180), player.playerData.rotationSpeed);
           break;

           case Player.InputDirections.down:
                RotationAngleHandler(Quaternion.Euler(0, 0, 0), player.playerData.rotationSpeed);
           break;
       }
        
    }


    void RotationAngleHandler(Quaternion angle, float speed)
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, angle, speed * Time.deltaTime);
    }
}
