using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool isShot;
    private Rigidbody2D rb;

    public float bulletSpeed;
    public Vector2 bulletDirection;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (isShot)
        {
            rb.velocity = transform.up * bulletSpeed;


        }
    }
}
