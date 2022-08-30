using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController
{
    BulletView bulletView;
    BulletModel bulletModel;
    BulletService bulletService;
    public BulletController(BulletModel bulletModel, BulletView bulletPrefab, float damage, Vector3 tankPosition, Quaternion rotation){
        bulletService = GameObject.FindObjectOfType<BulletService>();
        this.bulletModel = bulletModel;
        bulletView = GameObject.Instantiate<BulletView>(bulletPrefab, tankPosition, rotation);
        bulletView.speed = bulletModel.runSpeed;
        bulletView.bulletType = bulletModel.bulletType1;
        bulletView.damage = damage;
        Debug.Log(damage);
    }
}
