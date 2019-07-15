using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour{
  public GameObject lazerBeam;
  private float lazerSize;
  public GameObject laserChild;
  // private float lazerSizex;
  // private float lazerSizeY;
    // Start is called before the first frame update
    void Start()
    {
      lazerSize=0.1f*32f;// 32 * 0.1"scale"
      if(transform.position.x>=-50f){
        laserChild = Instantiate(lazerBeam, new Vector3(transform.position.x-lazerSize,transform.position.y,transform.position.z), transform.rotation);
      }
    }

    // Update is called once per frame
    void Update()
    {
      }
    private  void OnTriggerEnter2D(Collider2D hitInfo){
      if (hitInfo.transform.tag != "player" && hitInfo.transform.tag != "bullet"){
        suicide();
      }
    }
    public void suicide(){
      if( laserChild != null){
        laserChild.GetComponent<Lazer>().suicide();
      }
        Destroy(gameObject);
    }
}
