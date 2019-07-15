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
    void Start()
    {
      facingRight =true;
    }

    // Update is called once per frame
    void FixedUpdate(){
      if (Input.GetKey("left")){
        facingRight=false;
      }
      if (Input.GetKey("right")){
        facingRight=true;
      }
      if (Input.GetKeyDown("space")){
        if (Input.GetKey(up)){
          Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,90));
        }else if(Input.GetKey(down)){
          Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,-90));
        }else{
          if(facingRight){
            if (Input.GetKey(upDiagonal)){
             Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,45));
           }else if (Input.GetKey(downDiagonal)){
              Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,-45));
            }else{
                 Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,0));
           }
          }else{
            if (Input.GetKey(upDiagonal)){
             Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,135));
           }else if (Input.GetKey(downDiagonal)){
              Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,-135));
            }else{
                 Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,180));
           }
          }
      }
      }
    }
}
