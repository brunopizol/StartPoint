using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour
{
    public float damage;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            //other.GetComponent<PlayerController>().health-=damage;
            //other.GetComponent<PlayerController>().TakeDMG(damage);
            //other.GetComponent<PlayerController>().GUI.GetComponent<Image>().
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
