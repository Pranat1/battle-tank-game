using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
{
    public static T instance { get; private set;}
    private void Awake(){
        if(instance == null){
            instance = (T)this;
        }
        else{
            Destroy(this);
        }
    }
}
