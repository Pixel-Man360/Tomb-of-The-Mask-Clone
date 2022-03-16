using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour, IKiller
{
    public void KillPlayer()
    {
        Observer.OnGameOver();
    }
}
