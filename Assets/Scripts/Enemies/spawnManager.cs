using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TTL(time));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TTL(float time){

        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
