using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidalBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -100f;
    public float jumpForce = 20f;
    private float movingPos=1.5f;
    private Rigidbody2D rb;
    void Start()
    {
      rb = gameObject.GetComponent<Rigidbody2D>();
      rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      movingPos += Time.fixedDeltaTime;
      if (movingPos<1.5){
        gameObject.transform.Translate(0f,-jumpForce * Time.fixedDeltaTime,0f);

      }else{
        gameObject.transform.Translate(0f,jumpForce * Time.fixedDeltaTime,0f);
        if (movingPos>=3){
          movingPos=0;
        }
      }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo) {

        //Debug.Log(hitInfo.name);
      //  Instantiate(impactEffect, transform.position, transform.rotation);
      if (hitInfo.transform.tag == "player" || hitInfo.transform.tag == "ground"){
          Destroy(gameObject);
      }
    }
}
