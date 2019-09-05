using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aquaticEnemy : MonoBehaviour
{
    
    public float speed;
    public float Boostspeed;
    public float damage;
    public float Range;


    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.transform.position;
        float distance = Vector3.Distance(transform.position,target.transform.position);
        if(distance>Range){
            print("valor da distancia: "+distance);
            GetComponent<NavMeshAgent>().speed = Boostspeed;
        }else if(distance<=Range){
            GetComponent<NavMeshAgent>().speed = speed;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            other.GetComponent<Player>().getDamage(damage);
        }
    }
}
