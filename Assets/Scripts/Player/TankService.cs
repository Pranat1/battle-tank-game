using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class TankService : MonoSingletonGeneric<TankService>
{
    public TankListScriptableObject tankList;
    public Joystick joystick;
    public TankView tankView;
    public TankModel model;
    public NavMeshAgent agent = null;
    public BulletService bulletService;
    public TankController tankController;
    private void Start(){
        CreateNewTank(UnityEngine.Random.Range(0,2));
    }
    public TankController CreateNewTank(int index){
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        model = new TankModel(tankScriptableObject);
        TankController tank = new TankController(model, tankView);
        tankController = tank;
        return tank;
    }
    public void createBullet(Quaternion direction, Vector3 tPosition){
        bulletService.CreateNewBullet(UnityEngine.Random.Range(0,2), model.damage, tPosition, direction);
        
    }
}
