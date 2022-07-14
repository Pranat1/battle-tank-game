using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController
{
    BulletView bulletView;
    BulletModal bulletModal;
    BulletService bulletService;
    public BulletController(BulletModal bulletModal, BulletView bulletPrefab, float damage){
        bulletService = GameObject.FindObjectOfType<BulletService>();
        this.bulletModal = bulletModal;
        bulletView = GameObject.Instantiate<BulletView>(bulletPrefab, bulletService.tankPosition, Quaternion.identity);
        bulletView.speed = bulletModal.runSpeed;
        bulletView.bulletType = bulletModal.bulletType1;
        bulletView.damage = damage;
        Debug.Log(damage);
    }
}
