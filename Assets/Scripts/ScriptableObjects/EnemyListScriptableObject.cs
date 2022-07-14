using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyListScriptableObject", menuName = "ScriptableObjectList/ListEnemyTask")]
public class EnemyListScriptableObject : ScriptableObject
{
    public EnemyScriptableObject[] tanks;
}
