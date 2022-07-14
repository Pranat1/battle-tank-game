using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoSingletonGeneric<EnemyService>
{
    public EnemyListScriptableObject enemyList;
    public EnemyView enemyView;
    public EnemyModal modal;
    private void Start(){
        CreateNewTank(Random.Range(0,2));
    }
    public EnemyController CreateNewTank(int index){
        EnemyScriptableObject enemyScriptableObject = enemyList.tanks[index];
        modal = new EnemyModal(enemyScriptableObject);
        EnemyController tank = new EnemyController(modal, enemyView);
        return tank;
    }
}
