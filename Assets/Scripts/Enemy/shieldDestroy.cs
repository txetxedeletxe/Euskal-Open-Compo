using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldDestroy : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D hitInfo) {
    if (hitInfo.transform.tag == "shield" ){
        Destroy(gameObject);
    }
  }
}
