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

    TankView(){
         
    }

    private void Start()
    {   
        tankService = (TankService) FindObjectOfType<TankService>();
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            tankService.tankController.shoot(transform.rotation, transform.position);
        }
        tankService.agent.SetDestination(new Vector3(transform.position.x+tankService.joystick.Horizontal*speed, 0, transform.position.y + tankService.joystick.Vertical*speed));
        gameObject.transform.position += new Vector3(tankService.joystick.Horizontal*speed, 0, tankService.joystick.Vertical*speed);
        //Vector3 moveVector = (Vector3.right*tankService.joystick.Horizontal + Vector3.forward*tankService.joystick.Vertical);
        
        if(tankService.joystick.Horizontal != 0 || tankService.joystick.Vertical != 0){
            if(tankService.joystick.Horizontal < 0 && tankService.joystick.Vertical < 0){
                transform.rotation = Quaternion.Euler(0f, -(180f+Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI)+90f, 0f);
            }
            else if(tankService.joystick.Horizontal > 0 && tankService.joystick.Vertical < 0){
                transform.rotation = Quaternion.Euler(0f, -Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI+90f, 0f);
            }
            else if(tankService.joystick.Horizontal > 0 && tankService.joystick.Vertical > 0){
                transform.rotation = Quaternion.Euler(0f,-Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI+90f, 0f);
            }
            else if(tankService.joystick.Horizontal < 0 && tankService.joystick.Vertical > 0){
                transform.rotation = Quaternion.Euler(0f, -(180f + Mathf.Atan(tankService.joystick.Vertical/tankService.joystick.Horizontal)*180f/Mathf.PI)+90f, 0f);
            }
            
        }
        
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
