using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour,IKiller
{
    [Header("Dependencies:")]
    [SerializeField] private Transform _targetPosition;

    [Header("Values:")]
    [SerializeField] private float _risingSpeed;

    private bool _canRise = false;


    public void KillPlayer()
    {
        Observer.OnGameOver();
    }

    void OnEnable() 
    {
        Observer.onGameOver += StopRising;
        Observer.onLevelOver += StopRising;
        Observer.onPlayerStartedMoving += StartRising;
    }

    void OnDisable() 
    {
        Observer.onGameOver -= StopRising;
        Observer.onLevelOver -= StopRising;
        Observer.onPlayerStartedMoving -= StartRising;
    }


    void Update() 
    {
        RiseWaterLevel();
    }

    void RiseWaterLevel()
    {
        if(_canRise)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition.position, _risingSpeed * Time.deltaTime);
    }

    void StartRising()
    {
        _canRise = true;
    }

    void StopRising()
    {
        _canRise = false;
    }
}
