using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GUIController : MonoBehaviour
{
    [Header("objects")]
    public Image LifeBar;
    public TextMeshProUGUI EvolutionTime;
    // public TextMeshProUGUI PointsCounter;
    //public TextMeshProUGUI CoinCounter;
    public int CoinBank;
    public string path = "Assets/Resources/1Q2W34R.txt";
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
         LifeBar.fillAmount = player.GetComponent<Player>().life / 100;
        // PointsCounter.text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
