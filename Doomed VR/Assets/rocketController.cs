using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketController : MonoBehaviour
{
    public float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private LayerMask explodeLayer;

    private void Start()
    {
        rb.velocity = transform.forward * speed * 100 * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if ((explodeLayer.value & 1 << other.gameObject.layer) != 0)
        {
            Debug.Log("My mango is to blow up");
        }
    }
}
