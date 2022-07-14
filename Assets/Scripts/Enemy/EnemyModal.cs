using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModal
{
    public float runSpeed = 40f;
    public float health = 40;
    EnemyType enemyType1;
    float damage;
    public EnemyModal(EnemyScriptableObject enemyScriptableObject){
        enemyType1 = enemyScriptableObject.EnemyType;
        runSpeed = enemyScriptableObject.Speed;
        health = enemyScriptableObject.Health;
        damage = enemyScriptableObject.Damage;
    }

    public float RunSpeed { get; }
    public float Health { get; }
    public TankType EnemyType1 { get; }
}
