using Palmmedia.ReportGenerator.Core.CodeAnalysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement: IMover
{
    IEntityController _playercontroller;
    float _moveSpeed;
    float _moveBoundary;

    public HorizontalMovement(IEntityController  entityController)
    {
        _playercontroller = entityController;
        _moveSpeed = entityController.MoveSpeed;
        _moveBoundary = entityController.MoveBoundary;
    }

    public void FixedTick(float horizontal)
    {
        if(horizontal==0f) return;

        _playercontroller.transform.Translate(Vector3.right*horizontal*Time.deltaTime*_moveSpeed);

        float xboundary = Mathf.Clamp(_playercontroller.transform.position.x,-_moveBoundary,_moveBoundary);
        _playercontroller.transform.position=new Vector3(xboundary,_playercontroller.transform.position.y,0f);




    }


}
    

