using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
  public float lengtgh;
  private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
      lineRenderer = gameObject.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
      Vector3 endPos = transform.position;

    }
}
