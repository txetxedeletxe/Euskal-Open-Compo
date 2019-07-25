using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabEnemy : MonoBehaviour
{
    private GameObject masterFirePoint;
    private Rigidbody2D rb2d;
    private MasterFirepoint mFirepoint;
    public float cadency;
    private GameObject firePoint;
    private Animator anim;
    public GameObject Player;
    // Start is called before the first frame update
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
      if(Player.transform.position.x > transform.position.x){
        transform.rotation = Quaternion.Euler(0f,180f,0f);
      }else{
        transform.rotation = Quaternion.Euler(0f,0f,0f);
      }
        float prob = Random.Range(0f, 1f);
        if (prob >= 0.8f)
        {
            mFirepoint.enableAttack(cadency);
            anim.SetBool("Attac", true);


        }
        else
        {
          //  anim.SetBool("Attac", false);
            mFirepoint.disableAttack();
        }
    }

}
