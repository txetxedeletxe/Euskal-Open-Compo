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

    private void OnTriggerEnter2D(Collider2D hitInfo) {
      if (hitInfo.transform.tag == "player" || hitInfo.transform.tag == "ground"){
          Destroy(gameObject);
      }
    }

}
