using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObject/NewEnemyTask")]
public class EnemyScriptableObject : ScriptableObject
{
    public EnemyType EnemyType;
    public string EnemyName;
    public float Speed;
    public float Health;
    public float Damage;
}
