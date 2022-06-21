using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    TankView tankView;
    public TankController(TankModel tankModel, TankView tankPrefab){
        TankModel = tankModel;
        tankView = GameObject.Instantiate<TankView>(tankPrefab);
        tankView.speed = tankModel.runSpeed;
    }

    public TankModel TankModel { get;}

    
}
