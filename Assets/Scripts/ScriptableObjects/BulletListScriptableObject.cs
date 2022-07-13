using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletListScriptableObject", menuName = "ScriptableObjectList/ListBulletTask")]
public class BulletListScriptableObject : ScriptableObject
{
    public BulletScriptableObject[] bullets;
}
