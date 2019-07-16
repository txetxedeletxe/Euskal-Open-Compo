using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour{
  public GameObject lazerBeam;
  private float lazerSize;
  private GameObject laserChild;

  // private float lazerSizex;
  // private float lazerSizeY;
    // Start is called before the first frame update
    void Start()
    {
      lazerSize=-0.1f*32f;// 32 * 0.1"scale"
        laserChild = Instantiate(lazerBeam, transform.position +(transform.right * lazerSize), transform.rotation);
        laserChild.transform.parent = transform;
        //laserChild.transform.localPosition = new Vector3(lazerSize,0f,0f);
        laserChild.transform.localScale = new Vector3(1f, 1f, 1f);
    }


    // Update is called once per frame
    void Update(){}
    public void OnTriggerEnter2D(Collider2D hitInfo){
      if (hitInfo.transform.tag == "ground"){
          Destroy(gameObject);
      }
    }
}
