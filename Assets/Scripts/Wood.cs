using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float Speed = 10f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * -Speed;   
    }

   
}
