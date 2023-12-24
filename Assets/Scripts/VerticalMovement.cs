using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement: IMover
{

    IEntityController _entityController;
    float _moveSpeed = 3f;
    public VerticalMovement(IEntityController entityController)
    {
        _entityController = entityController;
        _moveSpeed = _entityController.MoveSpeed;
    }

    public void FixedTick(float vertical=1)
    {
        _entityController.transform.Translate(Vector3.back*vertical*_moveSpeed*Time.deltaTime);
    }


}
