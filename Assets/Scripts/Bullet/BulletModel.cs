using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public float runSpeed = 40f;
    public BulletType bulletType1;
    public BulletModel(BulletScriptableObject bulletScriptableObject){
        bulletType1 = bulletScriptableObject.BulletType;
        runSpeed = bulletScriptableObject.Speed;

    }

}
