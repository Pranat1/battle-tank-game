using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService>
{
    public TankListScriptableObject tankList;
    public Joystick joystick;
    public TankView tankView;
    public TankModel model;
    private void Start(){
        CreateNewTank(0);
    }
    public TankController CreateNewTank(int index){
        TankScriptableObject tankScriptableObject = tankList.tanks[index];
        model = new TankModel(tankScriptableObject);
        TankController tank = new TankController(model, tankView);
        return tank;
    }
}
