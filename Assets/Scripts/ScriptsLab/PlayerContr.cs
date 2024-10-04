using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public float speed = 8f;
    public float rotationSp = 30f;
    public float rayDistance = 5f;

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
        if (movimiento != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movimiento);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSp);
        }
        if (Input.GetMouseButtonDown(0))
        {
            shootRaycast();
        }
    }

    void shootRaycast()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * rayDistance, Color.black, 1f);
        if(Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if(hit.collider.CompareTag("Obstacle"))
            {
                Destroy(hit.collider.gameObject);
            }
            
        }

    }


    //Terminar el laberinto: Walls 1,2 y 3 son las indestructibles. Wall 4 serán las walls que podremos destruir con el uso de raycast.

    //Meta y Trigger: Crear un objeto al final del laberinto con un collider con isTrigger activado para que, cuando el player lo toque, se muestre el mensaje de victoria.
    //Contador de tiempo y Efectos visuales: implementar un contador de tiempo y efectos cuando el jugador destruye obstáculos.
}
