using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(EnemyView))]
public class TankChase : TankState
{
    public EnemyView enemyView;
    public TankView tankView;
    private void Awake(){
        enemyView = GetComponent<EnemyView>();
        tankView = GameObject.FindGameObjectWithTag("Player").GetComponent<TankView>();
    }
    public override void OnEnterState()
    {
        base.OnEnterState();
        enemyView.timeVar += Time.deltaTime;
        if(enemyView.timeVar > 2f){
            enemyView.timeVar -= 2f;
            enemyView.cuntroller.shoot(enemyView.gameObject.transform.rotation, enemyView.gameObject.transform.position);
        }
        Debug.Log(tankView.transform.position);
        enemyView.myNavMeshAgent.SetDestination(tankView.transform.position);

    }
    public override void OnExitState()
    {
        base.OnExitState();
    }
}
