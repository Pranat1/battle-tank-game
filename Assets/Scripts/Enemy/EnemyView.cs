using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class EnemyView : MonoBehaviour
{
    public float speed;
    public ColliderType colliderName = ColliderType.PetrolCollider;
    public float currentHealth;
    public GameObject playerObject;
    public NavMeshAgent myNavMeshAgent;
    public EnemyService enemyService;
    float timeVar = 0f;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        
        playerObject = GameObject.FindGameObjectWithTag("Player");
        enemyService = (EnemyService) FindObjectOfType<EnemyService>();
        if(currentHealth < 0f){
            Destroy(gameObject);
        }
        else if(playerObject == null){
            StartCoroutine(DestroyEnemy(2f));
        }
        else if(playerObject != null){
            if((gameObject.transform.position - playerObject.transform.position).sqrMagnitude < 100){
                timeVar += Time.deltaTime;
                if(timeVar > 2f){
                    timeVar -= 2f;
                    enemyService.enemyController.shoot(transform.rotation, transform.position);
                }
                myNavMeshAgent.SetDestination(playerObject.transform.position);
            }
        }
        else{
             gameObject.transform.position += new Vector3(0,0,speed*.1f);
        }

    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.GetComponent<petrolCollider>()){
            speed = -speed;
            }
    }
    private void SetDestinationToMousePosition(){
        myNavMeshAgent.SetDestination(playerObject.transform.position);
    }
    IEnumerator DestroyEnemy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);

    }
}
