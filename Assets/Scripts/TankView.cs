using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public float speed;
    TankService tankService;
    public TankType tankType;

    TankView(){
         
    }

    private void Start()
    {   
        tankService = (TankService) FindObjectOfType<TankService>();
    }
    private void Update()
    {
        gameObject.transform.position += new Vector3(tankService.joystick.Horizontal*speed, 0, tankService.joystick.Vertical*speed);
        if(tankService.joystick.Vertical/tankService.joystick.Horizontal > 0){
            gameObject.transform.rotation = Quaternion.Euler(0, Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*Mathf.Rad2Deg+ 90, 0);
        }
        else if((tankService.joystick.Vertical < 0 && tankService.joystick.Horizontal < 0) || (tankService.joystick.Vertical > 0 && tankService.joystick.Horizontal < 0)){
            gameObject.transform.rotation = Quaternion.Euler(0, Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*Mathf.Rad2Deg+ 270, 0);
        }
    }
}
