using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MyCharacterController,IEntityController
{
   
    [SerializeField] float _horizontalDirection = 0f;
 
    [SerializeField] float _jumpForce = 1500f;
   

    IMover _mover;
    Ijump _jump;
    IInputReader _input;
    float _horizontal;
    bool _isJump;
    bool _isDead=false;

   

    float IEntityController.MoveSpeed { get => _moveSpeed; set => _moveSpeed=value; }
    float IEntityController.MoveBoundary { get => _moveBoundary; set => _moveBoundary=value; }

    private void Awake()
    {
        _mover=new HorizontalMovement(this);
        _jump = new Jump(this);
        _input = new InputReader(GetComponent<PlayerInput>());
    }

    private void Update()
    {
        if(_isDead) return;

        _horizontal = _input.Horizontal;

        if(_input.IsJump)
        {
            _isJump = true;
        }
    }

    private void FixedUpdate()
    {
        _mover.FixedTick(_horizontal);

        if(_isJump)
        {
            _jump.FixedTick(_jumpForce);
          
        }
        _isJump = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        IEntityController entityController = other.GetComponent<IEntityController>();


        if (entityController != null)
        {
            _isDead = true;
            GameManager.Instance.StopGame();
        }
    }

   
}
