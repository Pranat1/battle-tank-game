using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    TankService tankService;
    public TankType tankType;

    private void Start()
    {   
        tankService = (TankService) FindObjectOfType<TankService>();
    }
    private void Update()
    {
        gameObject.transform.position += new Vector3(tankService.joystick.Horizontal*tankService.model.runSpeed, 0, tankService.joystick.Vertical*tankService.model.runSpeed);
    }
}
