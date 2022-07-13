using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankListScriptableObject", menuName = "ScriptableObjectList/ListNewTask")]
public class TankListScriptableObject : ScriptableObject
{
    public TankScriptableObject[] tanks;
}
