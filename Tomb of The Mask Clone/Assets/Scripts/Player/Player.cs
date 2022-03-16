using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerRotation))]
[RequireComponent(typeof(PlayerDead))]

public class Player : MonoBehaviour
{
    #region Data
    [Header("Dependencies:")]
    [SerializeField] internal PlayerData playerData;
    [SerializeField] internal Rigidbody2D rigidBody2d;
    [SerializeField] internal PlayerInput playerInput;
    [SerializeField] internal PlayerMovement playerMovement;
    [SerializeField] internal PlayerRotation playerRotation;
    [SerializeField] internal PlayerDead playerDead;

    internal float horizontal;
    internal float vertical;

    internal bool isOnWall = true;

    internal Camera cam;

    internal enum InputDirections
    {
        none,
        left,
        right,
        up,
        down

    };

    internal InputDirections directions;

    #endregion
    
    #region Initialization

    void Awake()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
        playerRotation = GetComponent<PlayerRotation>();
        playerDead = GetComponent<PlayerDead>();
        
        cam = Camera.main;
        directions = InputDirections.none;
    }

    void OnEnable()
    {
        Observer.onPlayerTouchWalls += PlayerOnWall;
        Observer.onGameOver += PlayerDead;
    }

    void OnDisable() 
    {
        Observer.onPlayerTouchWalls -= PlayerOnWall;
        Observer.onGameOver -= PlayerDead;
    }

    #endregion


    void PlayerOnWall(bool flag)
    {
        isOnWall = flag;

        if(isOnWall)
        {
            directions = InputDirections.none;
        }
    }

    void PlayerDead() 
    {
        directions = InputDirections.none;
    }

    void Update()
    {
        HandleInput();
        HandleRotation();
    }

    void FixedUpdate() 
    {
        HandleMovement();
    }

    void HandleInput()
    {
       if(isOnWall)
       {
           playerInput.TakeInput(this);
       }
    }

    void HandleRotation()
    {
       playerRotation.RotatePlayer(this);
    }

    void HandleMovement()
    {
        if(directions == InputDirections.none) 
        return;

        playerMovement.MovePlayer(this);
        
    }

    
}
