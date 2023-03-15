//script skriven av hibba
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour 
{
    private GameObject triggeringNPC; //npc
    private bool istriggeringnpc; //npc
    public TMP_Text npcText;
    private void Awake() {

    }

    void Update()
    {
        if(istriggeringnpc){ //npc dialog
            print("player is triggering with " + triggeringNPC); //används för att kolla om trigger funkar
            if(Input.GetKeyDown(KeyCode.E)){
                npcText.text = "Hello, My name is Bob, I have a quest for you. Would you like to take it? Y/N";
                
            }
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == "NPC"){
            istriggeringnpc = true;
            triggeringNPC = other.gameObject;
            npcText.gameObject.SetActive(true);
        }
        if(other.tag == "Coin"){
            Pointsystem.Points();
            Destroy(other.gameObject);
        }
    }
    void OnTriggerExit(Collider other) {
        npcText.text = "Press E to talk";
        npcText.gameObject.SetActive(false);
        istriggeringnpc = false;
        triggeringNPC = null;
    }
}
