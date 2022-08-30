using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObject/NewBulletTask")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletType BulletType;
    public string BulletName;
    public float Speed;

}
