using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService>
{
    public Joystick joystick;
    public TankView tankView;
    public TankModel model;
    private void Start(){
        model = new TankModel(TankType.None, .1f);
        TankController tank = new TankController(model, tankView);
    }
}
