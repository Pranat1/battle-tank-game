using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoSingleton<PlayerTank>
{
    // Start is called before the first frame update
    void Start()
    {
        EnemyTank.instance.print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
