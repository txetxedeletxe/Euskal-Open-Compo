using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    private bool up;
    private bool down;
    

    public Animator Lizard;
    private bool run;
    private bool jump;


    void Start()
    {
        // facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      run = Lizard.GetBool("Run");
      jump = Lizard.GetBool("Jump");

      if (run){
           transform.localPosition = new Vector3(7.4f, 6.3f, 0f);
       }
       if (jump){
           transform.localPosition = new Vector3(2.7f, 0.3f, 0f);
       }
       if (!run && !jump){
           transform.localPosition = new Vector3(5.6f, 9.5f, 0f);
       }

        up = false;
        down = false;
        if (Input.GetAxis("Vertical") != 0)
        {
           if(Input.GetAxis("Vertical") > 0.95f){
                up = true;
                down = false;
            }
            if (Input.GetAxis("Vertical") < -0.95f)
            {
                up = false;
                down = true;
            }

        }
        else{
            if (Input.GetButton("Up")){
                up = true;
                down = false;
            }
            else if (Input.GetButton("Down"))
            {
                up = false;
                down = true;
            }

        }
        if (up){
          transform.localRotation = Quaternion.Euler(0, 0, 90);
          transform.localPosition = new Vector3(transform.localPosition.x-3.5f,transform.localPosition.y+2.7f, transform.localPosition.z);
        }else if (down){
          transform.localRotation = Quaternion.Euler(0, 0, -90);
          transform.localPosition = new Vector3(transform.localPosition.x-3.2f,transform.localPosition.y-3.9f, transform.localPosition.z);
        }else if (Input.GetButton("DiagonalUp")){
              transform.localRotation = Quaternion.Euler(0, 0, 45);
              transform.localPosition = new Vector3(transform.localPosition.x-0.6f,transform.localPosition.y+2.8f, transform.localPosition.z);
        }else if (Input.GetButton("DiagonalDown")){
              transform.localRotation = Quaternion.Euler(0, 0, -45);
              transform.localPosition = new Vector3(transform.localPosition.x-0.3f,transform.localPosition.y-3.4f, transform.localPosition.z);
        }else{
          transform.localRotation = Quaternion.Euler(0, 0, 0);

        }
    }
}
