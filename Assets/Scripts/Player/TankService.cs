using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
        CreateNewTank(Random.Range(0,2));
    }
    public TankController CreateNewTank(int index){
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        model = new TankModel(tankScriptableObject);
        TankController tank = new TankController(model, tankView);
        tankController = tank;
        return tank;
    }
    public void createBullet(){
        bulletService.CreateNewBullet(Random.Range(0,2), model.damage);
    }
    public void setBulletSpeed(Quaternion direction, Vector3 tPosition){
        bulletService.direction = direction;
        bulletService.tankPosition = tPosition;
    }
}
