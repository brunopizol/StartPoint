using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
   

    [Header("properties")]
    public Transform player; 
    public Vector3 offset;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); 
        Vector3 nextPosition = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z); 
        transform.position = Vector3.Lerp(transform.position, nextPosition, Time.deltaTime * moveSpeed);
        
    }
}
