using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLvl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Nivel completado!");
            PlayerContr playerS = other.GetComponent<PlayerContr>();
            if(playerS != null)
            {
                float elapsedTime = playerS.GetElapsedTime();
                Debug.Log("Tiempo total: " + elapsedTime + " segundos.");
                
            }
            playerS.enabled = false;

            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector3.zero;
            }
        }
    }
}
