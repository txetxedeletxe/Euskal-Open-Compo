using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
   void Start()
    {
        rb.velocity = transform.right * speed;
    }

     void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.transform.tag != "player" && hitInfo.transform.tag != "bullet"){
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
      }
    }

}
