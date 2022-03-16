using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) => OnCollisionEffects(other);

    void OnCollisionExit2D(Collision2D other) => OffCollisionEffects(other);

    protected virtual void OnCollisionEffects(Collision2D other){}

    protected virtual void OffCollisionEffects(Collision2D other){}
}
