using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleStateBat : IEnemyState
{
    public IEnemyState DoState(BatAI enemy)
    {
       if(enemy._isIdle)
           return this;

       return enemy._movingState;
    }
}
