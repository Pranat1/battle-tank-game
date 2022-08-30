using System;
using UnityEngine;

public class ServicePoolBullet : ServicePool<BulletController>
{
    public BulletModel bulletModel;
    public BulletView bulletPrefab;
    public float damage;
    public Vector3 tankPosition;
    public Quaternion direction;



    public BulletController GetBullet(BulletModel bulletModel, BulletView bulletPrefab, float damage, Vector3 tankPosition, Quaternion direction){
        this.bulletModel = bulletModel;
        this.bulletPrefab = bulletPrefab;
        this.damage = damage;
        this.tankPosition = tankPosition;
        this.direction = direction;
        return GetItem();
    }
    protected override BulletController CreateItem(){

        BulletController bulletController = new BulletController(bulletModel, bulletPrefab, damage, tankPosition, direction);
        return bulletController;
    }
}