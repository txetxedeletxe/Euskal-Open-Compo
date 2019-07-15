using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normlbullet : MonoBehaviour
{
    public float speed = -100f;
    private Rigidbody2D rb;
  //  public GameObject impactEffect;
   void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    void FixedUpdate(){
    }

    private void OnCollisionEnter2D (Collision2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
      //  Instantiate(impactEffect, transform.position, transform.rotation);
      if (hitInfo.transform.tag != "bullet"){
          Destroy(gameObject);
      }
    }

}
