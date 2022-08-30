using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;


public class EnemyView : MonoBehaviour
{
    public float timeVar;
    public EnemyModel enemyModel;
    public EnemyController cuntroller;
    public ColliderType colliderName = ColliderType.PetrolCollider;
    public GameObject playerObject;
    public NavMeshAgent myNavMeshAgent;
    public EnemyService enemyService;
    public TankPetroling tankPetroling;
    [SerializeField]
    public TankChase tankChase;
    [SerializeField]
    public TankState currentState;
    

    void Start(){
        timeVar = 0f;
        SetState(tankPetroling);
    }

    // Update is called once per frame
    void Update()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        cuntroller.enemyStates(playerObject);

    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.GetComponent<petrolCollider>()){
            enemyModel.runSpeed = -enemyModel.runSpeed;
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
    public void destroy(){
        Destroy(gameObject);
    }
    public void startDestroyCoroutine(){
        StartCoroutine(DestroyEnemy(2f));
    }
    public void SetState(TankState tankState){
        if(currentState != null){
            currentState.OnExitState();
        }
        currentState = tankState;
        currentState.OnEnterState();
    }
}
