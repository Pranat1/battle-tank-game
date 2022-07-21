using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(EnemyView))]
public class TankPetroling : TankState
{
    public EnemyView enemyView;

    private void Awake(){
        enemyView = GetComponent<EnemyView>();
    }
    public virtual void OnEnterState(){}
    public virtual void OnExitState(){}
}
