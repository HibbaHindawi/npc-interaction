//script skriven av hibba
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pointsystem : MonoBehaviour
{
    static int points;
    public TMP_Text Coin;

    void Start()
    {
        
    }

    void Update()
    {
        Coin.text = "Points: "+ points;      
    }

    public static void Points(){
        points++;
    }
}
