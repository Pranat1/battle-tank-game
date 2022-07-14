using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    EnemyView enemyView;
    EnemyModal enemyModal;
    public EnemyController(EnemyModal enemyModal, EnemyView enemyPrefab){
        this.enemyModal = enemyModal;
        enemyView = GameObject.Instantiate<EnemyView>(enemyPrefab);
        enemyView.speed = enemyModal.runSpeed;
        enemyView.currentHealth = enemyModal.health;
    }
}
