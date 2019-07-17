using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCount : MonoBehaviour
{
  public int lives;
    // Start is called before the first frame update
    void Start(){}
    // Update is called once per frame
    void Update(){}
    private void OnTriggerEnter2D(Collider2D hitInfo) {
      if (hitInfo.transform.tag == "weapon"){
          lives -= 1;
          Debug.Log(lives);
          if (lives<=0){
            Destroy(gameObject);
          }
      }}
}
