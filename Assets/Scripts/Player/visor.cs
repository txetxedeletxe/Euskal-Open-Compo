using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    private bool facingRight;
    private string up = "w";
    private string down = "s";
    private string upDiagonal = "d";
    private string downDiagonal = "a";
    public Animator Lizard;
    bool run;
    bool jump;


    void Start()
    {

        facingRight = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        run = Lizard.GetBool("Run");
        jump = Lizard.GetBool("Jump");


        if (Input.GetKey("left"))
        {
            facingRight = false;
        }
        if (Input.GetKey("right"))
        {
            facingRight = true;
        }
        if (Input.GetKeyDown("space"))
        {
            if (Input.GetKey(up))
            {
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90));
            }
            else if (Input.GetKey(down))
            {
                Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -90));
            }
            else
            {
                if (facingRight)
                {
                    if (Input.GetKey(upDiagonal))
                    {

                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 45));
                    }
                    else if (Input.GetKey(downDiagonal))
                    {

                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -45));
                    }
                    else
                    {

                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
                    }
                }
                else
                {
                    if (Input.GetKey(upDiagonal))
                    {


                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 135));
                    }
                    else if (Input.GetKey(downDiagonal))
                    {

                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -135));
                    }
                    else
                    {
                        Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 180));
                    }
                }
            }
        }
        if (run)
        {

            transform.localPosition = new Vector3(7.4f, 6.3f, 0f);
        }
        if (jump)
        {
            transform.localPosition = new Vector3(2.7f, 0.3f, 0f);
        }
        if (!run && !jump)
        {
            transform.localPosition = new Vector3(5.6f, 9.5f, 0f);
        }

    }






}
