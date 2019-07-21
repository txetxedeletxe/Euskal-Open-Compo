using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeControler : MonoBehaviour
{
  private Camera cam;
  public GameObject lifebar;
  private GameObject lastbar;
  private GameObject prelastbar;
  private int barCount;
    // Start is called before the first frame update
    void Start(){
      cam = transform.parent.gameObject.GetComponent<Camera>();
      float height = 2f * cam.orthographicSize;
      float  camwidth = height * cam.aspect;
      transform.localPosition = new Vector3(-camwidth/2 +5f, height/2 -12f,1f);
    }

    // Update is called once per frame
    void Update(){}

    public void spawnbars(int numBars){ //  numBars must be always > 2
      barCount = numBars;
      prelastbar = Instantiate(lifebar,transform.position,transform.rotation);
      prelastbar.transform.parent = gameObject.transform;
      prelastbar.transform.localPosition = new Vector3(0f,0f,0f);
      for (int i=1 ; i<numBars-1;i++){
        lastbar = Instantiate(lifebar,transform.position,transform.rotation);
        lastbar.transform.parent = prelastbar.transform;
        lastbar.transform.localPosition = new Vector3(6f,0f,0f);
        prelastbar = lastbar;
      }
      lastbar = Instantiate(lifebar,transform.position,transform.rotation);
      lastbar.transform.parent = prelastbar.transform;
      lastbar.transform.localPosition = new Vector3(6f,0f,0f);

    }

    public void removeLife(){
      if( barCount  !=1){
        if (barCount != 2){
          prelastbar = prelastbar.transform.gameObject;
        }
        Destroy(lastbar);
        lastbar = prelastbar;
        barCount -=1;
    }
    }
}
