using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObject/NewTask")]
public class TankScriptableObject: ScriptableObject 
{
    public TankType TankType;
    public string TankName;
    public float Speed;
    public float Health;
    public float Damage;
}
