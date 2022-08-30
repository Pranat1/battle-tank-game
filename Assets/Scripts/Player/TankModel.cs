using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{
    public float runSpeed = 40f;
    float virtileMove = 0f;
    public TankType tankType1;
    public float health;
    public float damage;
    public float currentHealth;
    public TankModel(TankScriptableObject tankScriptableObject){
        currentHealth = tankScriptableObject.Health;
        tankType1 = tankScriptableObject.TankType;
        runSpeed = tankScriptableObject.Speed;
        health = tankScriptableObject.Health;
        damage = tankScriptableObject.Damage;
    }

    public float RunSpeed { get; }
    public float Health { get; }
    public TankType TankType1 { get; }
}
