﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
  public int lives;
  private bool canBeHit;
  private float countDown;
  public GameObject liveBars;
    // Start is called before the first frame update
    void Start(){
      canBeHit=true;
      countDown=1.5f;
      liveBars.GetComponent<LifeControler>().spawnbars(lives);
    }
    // Update is called once per frame
    void Update(){
      if(!canBeHit){
        if(countDown<=0){
          canBeHit=true;
        }else{
          countDown-=Time.deltaTime;
        }
      }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo) {

      if(canBeHit){
        if (hitInfo.transform.tag == "bullet"){
            canBeHit=false;
            countDown=1.5f;
            lives -= 1;
            Debug.Log(lives);
            liveBars.GetComponent<LifeControler>().removeLife();
          }
        }
    }
  }
