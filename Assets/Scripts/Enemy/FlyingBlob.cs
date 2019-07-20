using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBlob : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Player;
    private GameObject masterFirePoint;
    private Rigidbody2D rb2d;
    private Animator anim;
    private MasterFirepoint  mFirepoint;
    public float cadency;
    private Vector3 PlayerDirection;



    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        masterFirePoint = this.gameObject.transform.GetChild(0).gameObject;
        mFirepoint = masterFirePoint.GetComponent<MasterFirepoint>();
        mFirepoint.enableAttack(cadency);
      }
    // Update is called once per frame
    void FixedUpdate()
    {
       float prob = Random.Range(0f, 1f);
        if (prob >= 0.8f)
        {
            mFirepoint.enableAttack(cadency);
            anim.SetBool("Attacking", true);


        }
        else
        {
            anim.SetBool("Attacking", false);
            mFirepoint.disableAttack();
        }


        
        masterFirePoint.transform.Rotate(0f, 0f, 1f);
    }
        // gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x,gameObject.transform.rotation.y,gameObject.transform.rotation.z+ 10f);

}
