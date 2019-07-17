using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneMovement : MonoBehaviour
{
    // Start is called before the first frame update
    protected
    private Camera cam;
    public float camwidth;
    public float speed;
    void Start()
    {
      cam = transform.parent.gameObject.GetComponent<Camera>();
      float height = 2f * cam.orthographicSize;
      camwidth = height * cam.aspect;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      foreach (Transform ts in gameObject.GetComponentsInChildren<Transform>()){
        ts.gameObject.transform.Translate(-speed* Time.fixedDeltaTime,0f,0f);
      }
      transform.Translate(speed*Time.fixedDeltaTime,0f,0f);//por alguna razon bera be mobitzen da bestela
    }
}
