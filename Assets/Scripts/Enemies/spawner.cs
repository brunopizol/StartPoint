using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("properties")]
    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float descreaseTime;
    public float minTime = 0.65f;

    [Header("Game Objects")]
    public GameObject[] ObstaclePatterns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawn<=0){
            timeBtwSpawn = startTimeBtwSpawn;
            int rand = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[rand], transform.position, Quaternion.identity);
            
            
            if(startTimeBtwSpawn>minTime){
                startTimeBtwSpawn -= descreaseTime;
            }

        }
        else
        {
                timeBtwSpawn-= Time.deltaTime;
        }
        
    }
}
