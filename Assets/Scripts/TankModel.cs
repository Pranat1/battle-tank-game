using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float virtileMove = 0f;
    TankType TankType1;
    public TankModel(TankType tankType, float speed){
        TankType1 = tankType;
        runSpeed = speed;
    }

    public float RunSpeed { get; }
}
