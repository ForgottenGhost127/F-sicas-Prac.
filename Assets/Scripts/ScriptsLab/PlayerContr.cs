using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveHoriz, 0f, moveVert).normalized;
        rb.velocity = movimiento * speed;
    }

    //Terminar el laberinto: Walls 1,2 y 3 son las indestructibles. Wall 4 serán las walls que podremos destruir con el uso de raycast.
    //Implementar el Raycast: agregar lógica para disparar un raycast y destruir muros débiles.
    //Meta y Trigger: Crear un objeto al final del laberinto con un collider con isTrigger activado para que, cuando el player lo toque, se muestre el mensaje de victoria.
    //Contador de tiempo y Efectos visuales: implementar un contador de tiempo y efectos cuando el jugador destruye obstáculos.
}
