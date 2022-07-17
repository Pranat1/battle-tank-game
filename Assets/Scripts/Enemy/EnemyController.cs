using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    EnemyView enemyView;
    EnemyModel enemyModel;
    EnemyService enemyService;
    public EnemyController(EnemyModel enemyModel, EnemyView enemyPrefab){
        enemyService = GameObject.FindObjectOfType<EnemyService>();
        this.enemyModel = enemyModel;
        enemyView = GameObject.Instantiate<EnemyView>(enemyPrefab);
        enemyView.speed = enemyModel.runSpeed;
        enemyView.currentHealth = enemyModel.health;
    }
    public void shoot(Quaternion tForword, Vector3 tPosition){
        enemyService.createBullet();
        enemyService.setBulletSpeed(tForword, tPosition);
    }
}
