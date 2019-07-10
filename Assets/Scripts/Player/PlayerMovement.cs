using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //State variables
    [ReadOnly] public bool canJump = false;
    [Min(0)] public float jumpSquatDelayMs = 40;

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

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left"))
        {
            rb2d.AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            anim.SetBool("Run", true);
            renderer.flipX = true;
        }

        if (Input.GetKey("right"))
        {
            rb2d.AddForce(new Vector2(1000f * Time.deltaTime, 0));
            anim.SetBool("Run", true);
            renderer.flipX = false;
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

                rb2d.AddForce(new Vector2(0, 200f));
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
