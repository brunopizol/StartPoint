using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("properties")]
    public float life;
    public bool updateLife;

    [Header("Objects Settings")]
    public GameObject player;
    public GameObject GUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void getFood(float value, float size)
    {
        life += value;
        transform.localScale += new Vector3(size*0.5f, size*0.5f, size);
        GUI.GetComponent<GUIController>().LifeBar.fillAmount = life / 100;
    }
    public void getDamage(float value)
    {
        life -= value;
        GUI.GetComponent<GUIController>().LifeBar.fillAmount = life / 100;

    }
}
