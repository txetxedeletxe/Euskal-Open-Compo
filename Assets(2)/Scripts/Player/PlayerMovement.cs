using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement characteristics
    [Min(0)] public float horizontalMoveForce = 2000f;
    [Min(0)] public float jumpForce = 700f;
    [Min(0)] public float jumpSquatDelayMs = 20f;

    //State variables
     public bool canJump = false;
       public bool facingRight;


    private bool gonnaJump  = false;
    private float jumpStartTime;
   


    //Cached components
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {

        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
         facingRight = true;

}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-horizontalMoveForce * Time.fixedDeltaTime, 0));
            anim.SetBool("Run", true);
            
            //if (transform.localScale.x > 0)
            //    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
             
            if(facingRight)
            {
                transform.Rotate(0f, 180f, 0f);
                facingRight = false;
            }

        }

        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(horizontalMoveForce * Time.fixedDeltaTime, 0));
            anim.SetBool("Run", true);




            //if (transform.localScale.x < 0)
            //    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            if(!facingRight)
        {
                transform.Rotate(0f, 180f, 0f);
                facingRight = true;
            }
        }

        


        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            gonnaJump = true;
            jumpStartTime = Time.fixedTime;
            anim.SetBool("Jump", true);

        }
        if (!Input.GetKey("left") && !Input.GetKey("right")) {
            anim.SetBool("Run", false);
        }
        if (gonnaJump)
        {
            if (Time.fixedTime - jumpStartTime >= jumpSquatDelayMs/1000.0f)
            {
                gonnaJump = false;

                rb2d.AddForce(new Vector2(0, jumpForce));
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground"){
            canJump = true;
            anim.SetBool("Jump", false);
        }
    }
}
