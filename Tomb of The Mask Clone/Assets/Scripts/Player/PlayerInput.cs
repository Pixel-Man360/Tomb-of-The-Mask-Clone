using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    internal void TakeInput(Player player)
    {
        if(Input.touchCount <= 0)
        return;
        
        Touch touch = Input.GetTouch(0);

        if(touch.phase == TouchPhase.Began)
        {
            startTouchPosition = player.cam.ScreenToWorldPoint(touch.position);
        }

        else if(touch.phase == TouchPhase.Moved)
        {
            endTouchPosition = player.cam.ScreenToWorldPoint(touch.position);

            if(Vector2.Distance(endTouchPosition, startTouchPosition) >= player.playerData.swipeRange)
            {
               SetDirections(player);
            }
            startTouchPosition = player.cam.ScreenToWorldPoint(touch.position);
        }

        
    }

    private void SetDirections(Player player)
    {
        Vector2 direction = endTouchPosition - startTouchPosition;
       
        if(direction.x < -player.playerData.swipeRange)
        {
            player.directions = Player.InputDirections.left;
        }

        else if(direction.x > player.playerData.swipeRange)
        {
            player.directions = Player.InputDirections.right;
        }

        if(direction.y > player.playerData.swipeRange)
        {
            player.directions = Player.InputDirections.up;
        }

        else if(direction.y < -player.playerData.swipeRange)
        {
            player.directions = Player.InputDirections.down;
        }
    }

   
}
