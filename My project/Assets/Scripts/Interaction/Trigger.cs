//script skriven av hibba
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour 
{
    private GameObject triggeringNPC; //npc
    private bool istriggeringnpc; //npc

    public GameObject npcText;
    private void Awake() {

    }

    void Update()
    {
        if(istriggeringnpc){
            print("player is triggering with " + triggeringNPC); //används för att kolla om trigger funkar
            npcText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)){

            }
        }
        else{
            npcText.SetActive(false);
           
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == "NPC"){
            istriggeringnpc = true;
            triggeringNPC = other.gameObject;
        }
        if(other.tag == "Coin"){
            Pointsystem.Points();
            Destroy(other.gameObject);
        }
    }
    void OnTriggerExit(Collider other) {
        istriggeringnpc = false;
        triggeringNPC = null;
    }
}
