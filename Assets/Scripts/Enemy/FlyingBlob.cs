using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBlob : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject masterFirePoint;
    private Rigidbody2D rb2d;

    void Start()
    {

        masterFirePoint = this.gameObject.transform.GetChild(0).gameObject;
      }
    // Update is called once per frame
    void FixedUpdate()
    {
      masterFirePoint.transform.Rotate(0f,0f,127f);
      }
        // gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x,gameObject.transform.rotation.y,gameObject.transform.rotation.z+ 10f);

}
