using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEye : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    private Rigidbody2D rb2d;
    private Vector3 PlayerDirection;
    public GameObject explosion;
    private Animator anim;

    private bool hasTurned = false;
    private float distance;
    private float timer;

    void Start()
    {
      anim = gameObject.GetComponent<Animator>();
      rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerDirection = new Vector3(Player.transform.position.x - this.transform.position.x, Player.transform.position.y - this.transform.position.y, this.transform.position.z);
        rb2d.AddForce(PlayerDirection * 0.02f + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)), 0f);

        if(!hasTurned){

          distance = Vector3.Distance(Player.transform.position, transform.position);
          if( distance <20f){
            hasTurned =true;
            timer = 3f;
            anim.SetBool("kamikaze", true);
          }
        }else{
         timer -= Time.fixedDeltaTime;
         if (timer <=0){
           Instantiate(explosion,transform.position,transform.rotation);
           Destroy(gameObject);
         }
        }
        //if (Player.transform.position.x <= this.transform.position.x)
        //{
        //    if (!hasTurned)
        //    {
        //        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        //        hasTurned = !hasTurned;
        //    }
        //}
    }
    // gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x,gameObject.transform.rotation.y,gameObject.transform.rotation.z+ 10f);

}
