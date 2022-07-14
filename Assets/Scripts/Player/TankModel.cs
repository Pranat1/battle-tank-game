using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float virtileMove = 0f;
    public TankType tankType1;
    float health;
    public float damage;
    public TankModel(TankScriptableObject tankScriptableObject){
        tankType1 = tankScriptableObject.TankType;
        runSpeed = tankScriptableObject.Speed;
        health = tankScriptableObject.Health;
        damage = tankScriptableObject.Damage;
    }

    public float RunSpeed { get; }
    public float Health { get; }
    public TankType TankType1 { get; }
}
