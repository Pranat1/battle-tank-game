using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoSingletonGeneric<BulletService>
{
    public BulletListScriptableObject bulletList;
    public BulletView bulletView;
    public BulletModal modal;
    public Quaternion direction;
    public Vector3 tankPosition;
    public BulletController CreateNewBullet(int index, float damage){
        BulletScriptableObject bulletScriptableObject = bulletList.bullets[index];
        modal = new BulletModal(bulletScriptableObject);
        BulletController bullet = new BulletController(modal, bulletView, damage);
        return bullet;
    }
}
