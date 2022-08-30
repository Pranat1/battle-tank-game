using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyService : MonoSingletonGeneric<EnemyService>
{
    public EnemyListScriptableObject enemyList;
    public EnemyView enemyView;
    public EnemyModel model;
    public TankService player;
    public BulletService bulletService;
    public EnemyController enemyController;
    

    void Start(){
        CreateNewTank(Random.Range(0,2));
    }
    public EnemyController CreateNewTank(int index){
        
        EnemyScriptableObject enemyScriptableObject = enemyList.tanks[index];
        model = new EnemyModel(enemyScriptableObject);
        EnemyController tank = new EnemyController(model, enemyView);
        enemyController = tank;
        return tank;
    }
    void Update(){
        player = (TankService) FindObjectOfType<TankService>();
        //enemyView.playerObject = player.tankView;
    }
    public void createBullet(Quaternion direction,Vector3 tPosition){
        bulletService.CreateNewBullet(2, model.damage, tPosition, direction);
    }
}
