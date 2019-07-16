using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabEnemy : MonoBehaviour
{
  private GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        firePoint = this.gameObject.transform.GetChild(0).gameObject;
        firePoint.GetComponent<FirePoint>().spawnProjectile();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
