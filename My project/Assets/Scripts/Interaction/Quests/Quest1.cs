using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quest1 : MonoBehaviour
{
    static int points;
    public int totalpoints = 20;
    public TMP_Text Coin;
    public bool enabled;
    public Button Quest1Button;
    void Start()
    {
        Coin.gameObject.SetActive(false);
        enabled = false;
    }

    void Update()
    {
        if(enabled){
            Coin.gameObject.SetActive(true);
            Coin.text = "Points: "+ points;
        }
        if(points == totalpoints){
            enabled = false;
            
        }      
    }

    public static void Points(){
        points++;
    }
    public void ActivateQuest(){
        enabled = true;
    }
}
