using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    SpawnManager spawnManager;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Fruits"))
        {
            Debug.Log("you hit fruit");
            Destroy(collision.collider.gameObject);
           
            
            
        }

    }
}
