using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ServiceEvents : MonoSingletonGeneric<ServiceEvents>
{
    public event Action OnFire;
    public TankService tankService;

    public void InvokeFire(){
        OnFire?.Invoke();
    }
}
