using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    TankView tankView;
    TankModel tankModel;
    TankService tankService;
    public TankController(TankModel tankModel, TankView tankPrefab){
        tankService = GameObject.FindObjectOfType<TankService>();
        this.tankModel = tankModel;
        tankView = GameObject.Instantiate<TankView>(tankPrefab);
        tankView.speed = tankModel.runSpeed;
        tankView.tankType = tankModel.tankType1;
        tankView.damage = tankModel.damage;
        tankView.currentHealth = tankModel.health;
        tankService.tankView = tankView;
    }

    public TankModel TankModel { get;}
 
    public void shoot(Quaternion tForword, Vector3 tPosition){
        tankService.createBullet();
        tankService.setBulletSpeed(tForword, tPosition);
    }

    
}
