using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCount : MonoBehaviour
{
    public int lives;
    private Animator anim;
    private float timer;
    private float hitStunTime;
    // Start is called before the first frame update
    void Start()
    {
      hitStunTime = 1f;
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("DamageTaken")){
          timer += Time.deltaTime;
          if( timer>= hitStunTime){
            anim.SetBool("DamageTaken", false);
          }
        }

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.transform.tag == "weapon")
        {
            lives -= 1;
            anim.SetBool("DamageTaken", true);
            timer =0f;
            if (lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
