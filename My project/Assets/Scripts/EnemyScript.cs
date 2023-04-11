using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int amount){
        currentHealth -= amount;
        Debug.Log(currentHealth);
        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }
}
