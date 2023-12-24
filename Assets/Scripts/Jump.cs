using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Ijump
{
    Rigidbody _rigidbody;
    PlayerController _playerController;

    public bool CanJump => _rigidbody.velocity.y != 0f;

    public  Jump(PlayerController playerController)
    {
        _rigidbody=playerController.GetComponent<Rigidbody>();
    }

    public void FixedTick(float jumpForece)
    {
        if (CanJump ) return;

        _rigidbody.velocity = Vector3.zero;
        _rigidbody.AddForce(Vector3.up*Time.deltaTime*jumpForece);

    }






}
