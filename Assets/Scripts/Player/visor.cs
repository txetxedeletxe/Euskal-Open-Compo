using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    private bool facingRight;
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
        if(facingRight){
           Instantiate(bullet,transform.position,  Quaternion.Euler(0,0,0));
        }else{
           Instantiate(bullet, transform.position,  Quaternion.Euler(0,0,180));
        }
      }
    }
}
