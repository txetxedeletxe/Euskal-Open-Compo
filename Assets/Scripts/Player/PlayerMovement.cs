using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement characteristics
    [Min(0)] public float horizontalMoveForce = 1000f;
    [Min(0)] public float jumpForce = 200f;
    [Min(0)] public float jumpSquatDelayMs = 40f;

    //State variables
    private bool canJump;
    private bool facingRight;
    private bool gonnaJump;
    private float jumpStartTime;


    //Cached components
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer renderer;

    private float camWidth;

    // Start is called before the first frame update;
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
        canJump = false;
        facingRight = true;
        gonnaJump  = false;

        Camera cam = transform.parent.gameObject.GetComponent<Camera>();
        float height = 2f * cam.orthographicSize;
        camWidth = height * cam.aspect;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if(transform.localPosition.x <=((-camWidth/2)-10f) || transform.localPosition.x >= ((camWidth/2)+10f)){
        gameObject.GetComponent<Live>().hit();
        transform.localPosition = new Vector3(0f,-68,1f);
      }
        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-horizontalMoveForce * Time.fixedDeltaTime, 0));
            anim.SetBool("Run", true);

            if(facingRight){
                  transform.Rotate(0f, 180f, 0f);
                  facingRight = false;
              }
        }

        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(horizontalMoveForce * Time.fixedDeltaTime, 0));
            anim.SetBool("Run", true);
            if(!facingRight){
                transform.Rotate(0f, 180f, 0f);
                facingRight = true;
            }
        }
        if (Input.GetKey("up") && canJump)
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
          Collider2D collider = collision.collider;
          Vector3 contactPoint = collision.contacts[0].point;
          Vector3 contactCenter = collider.bounds.center;
          if(contactPoint.y> contactCenter.y){
            canJump = true;
            anim.SetBool("Jump", false);
          }
        }
    }
}
