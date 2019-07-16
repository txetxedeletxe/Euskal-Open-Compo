using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    private string up = "w";
    private string down = "s";
    private string upDiagonal = "d";
    private string downDiagonal = "a";

    void Start()
    {
        // facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(up)){
          transform.localRotation = Quaternion.Euler(0, 0, 90);
        }else if (Input.GetKey(down)){
          transform.localRotation = Quaternion.Euler(0, 0, -90);
        }else if (Input.GetKey(upDiagonal)){
              transform.localRotation = Quaternion.Euler(0, 0, 45);
        }else if (Input.GetKey(downDiagonal)){
              transform.localRotation = Quaternion.Euler(0, 0, -45);
        }else{
          transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
