using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public float speed = 8f;
    public float rotationSp = 30f;
    public float rayDistance = 5f;

    private Rigidbody rb;
    private float startTime;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startTime = Time.time;
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
    public float GetElapsedTime()
    {
        return Time.time - startTime;
    }

}
