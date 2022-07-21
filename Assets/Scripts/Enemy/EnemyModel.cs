using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel
{
    public float runSpeed = 40f;
    public float health = 40f;
    public float currentHealth = 40f;
    EnemyType enemyType1;
    public float damage;
    public EnemyModel(EnemyScriptableObject enemyScriptableObject){
        enemyType1 = enemyScriptableObject.EnemyType;
        runSpeed = enemyScriptableObject.Speed;
        health = enemyScriptableObject.Health;
        damage = enemyScriptableObject.Damage;
    }

    public float RunSpeed { get; }
    public float Health { get; }
    public TankType EnemyType1 { get; }
}
