using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Data/PlayerData", order = 0)]
public class PlayerData : ScriptableObject 
{
    public float movementSpeed = 800f;
    public float rotationSpeed;
    public float swipeRange = 1f;
    
}
