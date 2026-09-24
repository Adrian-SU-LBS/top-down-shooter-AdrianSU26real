using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform player;
    [SerializeField] float moveSpeed = 3f;
    Rigidbody2D rb;
    Vector2 direction;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            direction = (player.position - transform.position).normalized;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }
}
