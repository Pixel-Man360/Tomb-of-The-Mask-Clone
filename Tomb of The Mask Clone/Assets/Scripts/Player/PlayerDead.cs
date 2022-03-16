using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    void OnEnable() 
    {
        Observer.onGameOver += GameOverOrLevelOver;
        Observer.onLevelOver += GameOverOrLevelOver;
    }

    void OnDisable() 
    {
        Observer.onGameOver -= GameOverOrLevelOver;
        Observer.onLevelOver -= GameOverOrLevelOver;
    }

    void GameOverOrLevelOver() => Destroy(this.gameObject);
}
