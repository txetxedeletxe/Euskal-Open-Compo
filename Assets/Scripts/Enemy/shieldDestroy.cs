using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldDestroy : MonoBehaviour
{
  public GameObject scripter;
  GameController gamecontroller;
  public void Start()
  {
    gamecontroller = scripter.GetComponent<GameController>();
  }
  private void OnTriggerEnter2D(Collider2D hitInfo) {
    if (hitInfo.transform.tag == "shield" ){
      gamecontroller.updateEnemyCount();
        Destroy(gameObject);
    }
  }
}
