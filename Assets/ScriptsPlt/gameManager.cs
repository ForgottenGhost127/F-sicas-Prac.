using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;

    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        //RespawnPlayer();
    //    }
    //}
    void RespawnPlayer()
    {
        player.transform.position = respawnPoint.position;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    
    
}
