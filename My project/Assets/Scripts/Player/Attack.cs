using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public EnemyScript enemyscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if((other.tag == "Enemy") && (Input.GetKeyDown(KeyCode.Mouse0))){
            Debug.Log("is Colliding");
            enemyscript.TakeDamage(20);
        }
    }
}
