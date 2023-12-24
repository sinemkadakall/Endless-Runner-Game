using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyController : MyCharacterController,IEntityController
{
   
    [SerializeField] float _maxLifeTime = 10f;
    float _currentLifeTime = 0f;
    VerticalMovement _mover;

    float IEntityController.MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
    float IEntityController.MoveBoundary { get => _moveBoundary; set => _moveBoundary = value; }


    private void Awake()
    {
        _mover = new VerticalMovement(this);
    }
    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime>_maxLifeTime)
        {
            _currentLifeTime = 0f;
            KillYourSelf();
        }
    }

   
    private void FixedUpdate()
    {
        _mover.FixedTick();
    }
    void KillYourSelf()
    {
        EnemyManager.Instance.SetPool(this);
    }
}
