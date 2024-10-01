using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PO_Sway : MonoBehaviour
{
    public float moveDist = 3.5f;
    public float speed = 2f;
    public bool isLocalMove;
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = (isLocalMove) ? transform.localPosition : transform.position;
    }

    void Update()
    {
        float dir = moveDist > 0f ? 1f : -1f;
        float movement = Mathf.PingPong(Time.time * speed, Mathf.Abs(moveDist));

        if (isLocalMove)
            transform.localPosition = originalPosition - transform.forward * movement * dir;
        else 
            transform.position = originalPosition - Vector3.forward * movement * dir;
    }
}
