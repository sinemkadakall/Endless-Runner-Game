using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    [Range(0.01f, 2f)]
    [SerializeField] float _moveSpeed=0.3f;
    Material _material;

     void Awake()
    {
        _material = GetComponentInChildren<MeshRenderer>().material;
            
    }
     void Update()
    {
        _material.mainTextureOffset += Vector2.down * Time.deltaTime*_moveSpeed;
    }
}
