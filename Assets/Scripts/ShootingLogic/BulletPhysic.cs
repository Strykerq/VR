using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physic : MonoBehaviour
{
    Rigidbody rb;
    private float _bulletForce = 5f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            rb.AddForce(transform.up * _bulletForce, ForceMode.Impulse);         
        }       
    }
}
