using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour/*  :  MonoSingletonGeneric<PlayerController> */
{
    public Joystick joystick;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float virtileMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal*runSpeed;
        virtileMove = joystick.Vertical*runSpeed;

        gameObject.transform.position += new Vector3(horizontalMove, 0, virtileMove);
    }
}
