using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMoving : MonoBehaviour
{
    public float speed = 3f;
    public float range = 5f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.PingPong(Time.time * speed, range), 0, 0);
    }
}
