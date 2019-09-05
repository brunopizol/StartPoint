using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoints : MonoBehaviour
{
    [Header("properties")]
    public GameObject Obstacle;
    // Start is called before the first frame update
    void Start()
    {
     Instantiate(Obstacle, transform.position, Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
