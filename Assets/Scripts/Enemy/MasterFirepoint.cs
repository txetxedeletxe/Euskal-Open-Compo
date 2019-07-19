using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterFirepoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){}
    // Update is called once per frame
    void Update(){}

    public void enableAttack(float cadencyUpdate){
      foreach (FirePoint ts in gameObject.GetComponentsInChildren<FirePoint>()){
        ts.gameObject.GetComponent<FirePoint>().cadency = cadencyUpdate;
        ts.gameObject.GetComponent<FirePoint>().canAttack = true;
      }
    }
    public void disableAttack(){
      foreach (FirePoint ts in gameObject.GetComponentsInChildren<FirePoint>()){
        ts.gameObject.GetComponent<FirePoint>().canAttack = false;
      }
    }

}
