using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityController
{
   
     Transform transform { get; }
     public float MoveSpeed { get; set; }
     public float MoveBoundary { get;  set; }





}
