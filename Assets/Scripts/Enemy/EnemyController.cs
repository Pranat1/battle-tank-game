using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    EnemyView enemyView;
    EnemyModel enemyModel;
    EnemyService enemyService;
    float timeVar = 0f;
    public EnemyController(EnemyModel enemyModel, EnemyView enemyPrefab){
        enemyService = GameObject.FindObjectOfType<EnemyService>();
        this.enemyModel = enemyModel;
        enemyView = GameObject.Instantiate<EnemyView>(enemyPrefab);
        enemyView.cuntroller = this;
        enemyView.enemyModel = enemyModel;
    }
    public void enemyStates(GameObject playerObject){
        
        if(enemyModel.currentHealth < 0f){
            enemyView.destroy();
        }
        else if(playerObject == null){
            enemyView.startDestroyCoroutine();
        }
        else if(playerObject != null){
            if((enemyView.gameObject.transform.position - playerObject.transform.position).sqrMagnitude < 100){
                enemyView.SetState(enemyView.tankChase);
            }
        }
        else{
             enemyView.gameObject.transform.position += new Vector3(0,0,enemyModel.runSpeed*.1f);
        }
    }
    public void shoot(Quaternion tForword, Vector3 tPosition){
        enemyService.createBullet(tForword, tPosition);
    }
}
