using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class rocketController : MonoBehaviour
{
    public float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private LayerMask explodeLayer;
    [SerializeField] private GameObject explosionParticle;

    private void Start()
    {
        rb.velocity = (transform.forward * speed * 100 * Time.deltaTime) + (transform.up * 250 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if ((explodeLayer.value & 1 << other.gameObject.layer) != 0)
        {
            GameObject explosion = Instantiate(explosionParticle, transform.position, quaternion.identity);
            explosion.transform.parent = null;
            
            Destroy(gameObject);
        }
    }
}
