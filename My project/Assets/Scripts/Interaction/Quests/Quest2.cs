using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Quest2 : MonoBehaviour
{
    public bool enabled;
    public Button Quest2Button;
    static int kills;
    public TMP_Text EnemyCounter;
    public Slider Slider2;
    public int maxKills = 25;
    public GameObject EnemyBar;
    public Image img2;
    void Start()
    {
        enabled = false;
        SetMaxKills(maxKills);
        Slider2.value = 0;
    }

    void Update()
    {
        if(enabled){
            EnemyBar.gameObject.SetActive(true);
            EnemyCounter.text = "Kills: "+ kills + "/ 25";
            SetKills(kills);
            if(kills == maxKills){
            enabled = false;
            EnemyBar.SetActive(false);
            img2.color = Color.green;
            } 
        }    
    }

    public static void Kills(){
        kills++;
    }
    public void ActivateQuest(){
        enabled = true;
    }

    public void SetMaxKills(int kill){
        Slider2.maxValue = kill;
    }
    public void SetKills(int kill){
        Slider2.value = kill;
    }
}
