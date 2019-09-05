using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("properties")]
    public float speed;
    public float dashDistance;
    public float maxHeight;
    public float minHeight;
    public float smoothTime;
    public float health;
    
    private Vector3 targetPos;
    private Vector3 velocity = Vector3.zero;


    [Header("Game Objects")]
    public GameObject player;
    public Rigidbody rb;
    public GameObject GUI;
    private float movx;
    private float movy;
    private Vector3 moveDir;
    public int maxVelocityChange;


    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
        GUI = GameObject.Find("GUI");
        
         targetPos = new Vector3(transform.position.x, transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void LateUpdate() {

        movx = Input.GetAxisRaw("Horizontal");
        movy = Input.GetAxisRaw("Vertical");
        
        moveDir = new Vector3(movx, 0f, movy);
        moveDir *= speed;
        
        
        velocity = rb.velocity;
        Vector3 velocityChange = (moveDir - velocity);
        
        velocityChange.y = 0;
        
        
        rb.AddForce(velocityChange, ForceMode.VelocityChange);
         


    }

}
