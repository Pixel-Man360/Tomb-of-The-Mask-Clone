using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStateBat : IEnemyState
{
    private Vector2 _nextPosition;

    public IEnemyState DoState(BatAI enemy)
    {
        if(!enemy._isIdle)
        {
            MoveBat(enemy);
            return this;
        }

        return enemy._idleState;
    }


    void MoveBat(BatAI bat)
    {
        if(Vector2.Distance(bat.transform.position, bat._startingPosition) < 0.01f)
        {
            _nextPosition = bat._endingPosition;
            bat._isIdle = true;
        }

        else if(Vector2.Distance(bat.transform.position, bat._endingPosition) < 0.01f)
        {
            _nextPosition = bat._startingPosition;
            bat._isIdle = true;
        }


        bat.transform.position = Vector2.MoveTowards(bat.transform.position, _nextPosition, bat._moveSpeed * Time.deltaTime);
    }
    
}
