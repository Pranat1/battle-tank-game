using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public float speed;
    public ColliderType colliderName = ColliderType.PetrolCollider;
    public float currentHealth;


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0,0,speed*.1f);
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.GetComponent<petrolCollider>().colliderType == colliderName){
            speed = -speed;
            }
    }
}
