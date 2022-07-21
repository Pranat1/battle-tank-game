using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TankView : MonoBehaviour
{
    public float speed;
    TankService tankService;
    public TankType tankType;
    public float damage;
    public float currentHealth;
    public bool getKeyDownSpace;
    public TankController controller;

    private void Start()
    {   
        tankService = (TankService) FindObjectOfType<TankService>();
    }
    
    public void destroy(){
        Destroy(gameObject);
    }
    private void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            getKeyDownSpace = true;
        }
        else{
            getKeyDownSpace = false;
        }
        controller.enemyStates();
        
        /* gameObject.transform.rotation =  Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y - Vector3.Angle(gameObject.transform.forward, new Vector3(tankService.joystick.Horizontal, 0, tankService.joystick.Vertical*speed)), gameObject.transform.rotation.z); */
        
/*         gameObject.transform.position += new Vector3(tankService.joystick.Horizontal*speed, 0, tankService.joystick.Vertical*speed);
        if(tankService.joystick.Vertical/tankService.joystick.Horizontal > 0){
            gameObject.transform.rotation = Quaternion.Euler(0, Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*Mathf.Rad2Deg+ 90, 0);
        }
        else if((tankService.joystick.Vertical < 0 && tankService.joystick.Horizontal < 0) || (tankService.joystick.Vertical > 0 && tankService.joystick.Horizontal < 0)){
            gameObject.transform.rotation = Quaternion.Euler(0, Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*Mathf.Rad2Deg+ 270, 0);
        } */
    }
}
