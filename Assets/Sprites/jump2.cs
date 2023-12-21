using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2 : MonoBehaviour
{
    public float jumpForce = 5f;    // The force with which the enemy jumps
    private Rigidbody2D rb;
    public bool isGround = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Jump forward constantly
        transform.position += Vector3.left * jumpForce * Time.deltaTime;
        transform.position += Vector3.up * jumpForce * Time.deltaTime;
    }
}