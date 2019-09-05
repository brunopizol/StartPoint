using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    [Header("properties")]
    public float value;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        value = value * size;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            other.GetComponent<Player>().getFood(value, size);
            Destroy(gameObject);
        }
    }
}
