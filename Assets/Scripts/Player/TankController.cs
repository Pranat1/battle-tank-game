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
        tankView.tankType = tankModel.tankType1;        
        tankView.controller = this;
    }

    public TankModel TankModel { get;}
 
    public void shoot(Quaternion tForword, Vector3 tPosition){
        tankService.createBullet(tForword, tPosition);
        ServiceEvents.Instance.InvokeFire();

    }
    public void enemyStates(){
        if(tankModel.currentHealth < 0){
            tankView.destroy();
        }
        else if (tankView.getKeyDownSpace)
        {
            shoot(tankView.transform.rotation, tankView.transform.position);
        }
        else if(tankService.joystick.Horizontal != 0 || tankService.joystick.Vertical != 0){
            Debug.Log(tankService.joystick.Horizontal*tankModel.runSpeed);
            tankView.gameObject.transform.position += new Vector3(tankService.joystick.Horizontal*tankModel.runSpeed, 0, tankService.joystick.Vertical*tankModel.runSpeed);
            if(tankService.joystick.Horizontal < 0 && tankService.joystick.Vertical < 0){
                tankView.transform.rotation = Quaternion.Euler(0f, -(180f+Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI)+90f, 0f);
            }
            else if(tankService.joystick.Horizontal > 0 && tankService.joystick.Vertical < 0){
                tankView.transform.rotation = Quaternion.Euler(0f, -Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI+90f, 0f);
            }
            else if(tankService.joystick.Horizontal > 0 && tankService.joystick.Vertical > 0){
                tankView.transform.rotation = Quaternion.Euler(0f,-Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI+90f, 0f);
            }
            else if(tankService.joystick.Horizontal < 0 && tankService.joystick.Vertical > 0){
                tankView.transform.rotation = Quaternion.Euler(0f, -(180f + Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI)+90f, 0f);
            }
        }
            
    }

    
}
