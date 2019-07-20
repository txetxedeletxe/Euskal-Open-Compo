using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
  public GameObject projectile;
  public float cadency;
  public bool canAttack;
  private float time;
    // Start is called before the first frame update

    void Start(){
      time =0f;
    }

    // Update is called once per frame
    void Update(){
      if (canAttack){
        time += Time.deltaTime;
        if( time >= cadency){
          time =0;
          spawnProjectile();
                
            }
    }
    }

    public void spawnProjectile(){
      Instantiate(projectile, transform.position, transform.rotation);
    }
}
