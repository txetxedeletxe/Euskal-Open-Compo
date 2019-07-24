using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiedControl : MonoBehaviour
{
  public GameObject shield;
  private float shieldsize = 32f;
  private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
      cam = transform.parent.gameObject.GetComponent<Camera>();
      float height = 2f * cam.orthographicSize;
      float camwidth = height * cam.aspect;

      GameObject rightWall =Instantiate(shield, transform.position,Quaternion.Euler(0,0,0));
      GameObject leftWall =Instantiate(shield, transform.position,Quaternion.Euler(0,0,0));
      GameObject upWall =Instantiate(shield, transform.position,Quaternion.Euler(0,0,90));
      GameObject downWall =Instantiate(shield, transform.position,Quaternion.Euler(0,0,90));

      rightWall.transform.parent = transform.parent;
      leftWall.transform.parent = transform.parent;
      upWall.transform.parent = transform.parent;
      downWall.transform.parent = transform.parent;
      rightWall.transform.localPosition = new Vector3(-(camwidth/2)-50f,0f,0f);
      rightWall.transform.localScale = new Vector3(1f,(height+100f)/shieldsize, 1f);
      leftWall.transform.localPosition = new Vector3((camwidth/2)+50f,0f,0f);
      leftWall.transform.localScale = new Vector3(1f,(height+100f)/shieldsize, 1f);
      upWall.transform.localPosition = new Vector3(0f, (height/2)+50f,0f);
      upWall.transform.localScale = new Vector3(1f,(camwidth+100f)/shieldsize, 1f);
      downWall.transform.localPosition = new Vector3(0f,-(height/2)-50f,0f);
      downWall.transform.localScale = new Vector3(1f,(camwidth+100f)/shieldsize, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
