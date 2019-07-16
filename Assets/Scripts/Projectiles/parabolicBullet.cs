using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabolicBullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
     public GameObject impactEffect;
    public GameObject crabGrenadeExplosion;
    public float horizontalMoveForce = 100f;
    public float jumpForce = 200f;
    void Start()
    {
          rb = gameObject.GetComponent<Rigidbody2D>();
          rb.AddForce(new Vector2(horizontalMoveForce, jumpForce));
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D hitInfo) {
      // Debug.Log(hitInfo.name);
      if (hitInfo.transform.tag == "player" || hitInfo.transform.tag == "ground"){

      Instantiate(crabGrenadeExplosion, transform.position, transform.rotation);
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,0));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,30));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,60));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,90));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,120));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,150));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,180));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,210));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,240));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,270));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,300));
       Instantiate(impactEffect, transform.position,  Quaternion.Euler(0,0,330));
       Destroy(gameObject);
   }}
}
