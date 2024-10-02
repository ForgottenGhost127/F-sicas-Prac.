using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RestartL();
        }
    }
    void RestartL()
    {
       // Puedes hacer que el jugador reaparezca o simplemente reiniciar la escena
       //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    
}
