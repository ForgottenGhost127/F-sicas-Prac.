using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 6f;
    private float velY = 0;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void Update()
    {
        float mHorizontal = Input.GetAxis("Horizontal");
        float mVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(mHorizontal, velY, mVertical) * speed;
        rb.AddForce(movement);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //rb.velocity = new Vector3(0, jumpForce, 0);
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            velY = jumpForce;
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("PlatStatic") || 
         collision.gameObject.CompareTag("PlatMovem") || collision.gameObject.CompareTag("PlatVanish"))
        {
            isGrounded = true;
        }
      

    }
}
