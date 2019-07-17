using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    private float width;
    void Start(){}

    // Update is called once per frame
    void FixedUpdate()
    {
        width = transform.parent.GetComponent<sceneMovement>().camwidth;
        if( width!=0){
          if(transform.localPosition.x<=(-width/2f -32f)){
            Destroy(gameObject);
          }
    }

    }
}
