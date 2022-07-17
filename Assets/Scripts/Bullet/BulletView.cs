using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    public BulletType bulletType;
    public float speed;
    BulletService bulletService;
    public float damage = 0f;
    // Start is called before the first frame update
    void Start()
    {
        bulletService = GameObject.FindObjectOfType<BulletService>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation =  bulletService.direction;
        transform.position += transform.forward*.1f;
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.GetComponent<EnemyView>() && bulletType != BulletType.Enemy){
            other.gameObject.GetComponent<EnemyView>().currentHealth -= damage;
            }
        else if(other.gameObject.GetComponent<TankView>() && ((bulletType != BulletType.Red) || (bulletType != BulletType.Blue))){
            other.gameObject.GetComponent<TankView>().currentHealth -= damage;
            }
    }
}
