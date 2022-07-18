using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnd : MonoBehaviour
{
    public GameObject playerObject;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        if(playerObject == null){
            StartCoroutine(DestroyLevel(4f));
        }
    }
    IEnumerator DestroyLevel(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);

    }
}
