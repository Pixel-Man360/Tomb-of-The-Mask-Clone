using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAI : MonoBehaviour, IKiller
{
    internal IEnemyState _enemyState;

    internal IdleStateBat _idleState = new IdleStateBat();
    internal MovingStateBat _movingState = new MovingStateBat();
    
    [SerializeField] internal Vector2 _startingPosition;
    [SerializeField] internal Vector2 _endingPosition;
    [SerializeField] internal float _moveSpeed = 0.5f;

    internal bool _isIdle = true;

    void Awake() 
    {
        _enemyState = _idleState;
    }


    void Update()
    {
        _enemyState = _enemyState.DoState(this);

        if(_enemyState == _idleState)
        {
            StartCoroutine(GotoMovement());
        }
    }

    internal IEnumerator GotoMovement()
    {
        _isIdle = true;

        yield return new WaitForSeconds(1f);
        
        _isIdle = false;
    }

    public void KillPlayer()
    {
        _isIdle = true;
        Observer.OnGameOver();
    }
}
