using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoSingletonGeneric<BulletService>
{
    public BulletListScriptableObject bulletList;
    public BulletView bulletView;
    public BulletModel model;
    private ServicePoolBullet servicePoolBullet;
    private void Start(){
        servicePoolBullet = GetComponent<ServicePoolBullet>();
    }
    public BulletController CreateNewBullet(int index, float damage, Vector3 tankPosition, Quaternion direction){
        BulletScriptableObject bulletScriptableObject = bulletList.bullets[index];
        model = new BulletModel(bulletScriptableObject);
        BulletController bullet = servicePoolBullet.GetBullet(model, bulletView, damage, tankPosition, direction);
        //BulletController bullet = new BulletController(model, bulletView, damage, tankPosition, direction);
        return bullet;
    }
}
