using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool canJump;
    private bool gonnaJump;
    private float jumpTime;
    // Start is called before the first frame update
    void Start()
    {
        canJump = false;
        gonnaJump = false;
        jumpTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("Run", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("Run", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown("up")&& canJump)
        {
            canJump = false;
            gonnaJump = true;
            jumpTime = 0.05f;
            gameObject.GetComponent<Animator>().SetBool("Jump", true);

        }
        if (!Input.GetKey("left") && !Input.GetKey("right")) { 
            gameObject.GetComponent<Animator>().SetBool("Run", false);
        }
        if (gonnaJump)
        {
            jumpTime -= Time.deltaTime;
            if (jumpTime <= 0f)
            {
                gonnaJump = false;
                
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground"){
            canJump = true;
            gameObject.GetComponent<Animator>().SetBool("Jump", false);
        }
    }
}
