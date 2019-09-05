using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evolutionTime : MonoBehaviour
{
    public  int tempoInicial;
    public GameObject GUI;
    public double timeLeft;
    public double aceleration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         timeLeft -= Time.deltaTime*aceleration;
         GUI.GetComponent<GUIController>().EvolutionTime.text = timeLeft.ToString("0");
     if ( timeLeft < 0 )
     {
         
     }
        
    }
}
