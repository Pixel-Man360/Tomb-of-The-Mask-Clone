using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, ICollectible
{
    public void Collect() => Destroy(this.gameObject);
}
