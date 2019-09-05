using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    public int coinValue;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation =  Quaternion.Euler(90f, transform.rotation.y, transform.rotation.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            //other.GetComponent<PlayerController>().health-=damage;
            //other.GetComponent<PlayerController>().GetCoin(coinValue);
            
            Destroy(gameObject);
        }
        if(other.CompareTag("end")){
            Destroy(gameObject);
        }
    }
    IEnumerator DestroyAfterTime(float time){

        yield return new WaitForSeconds(time);
    }
}



