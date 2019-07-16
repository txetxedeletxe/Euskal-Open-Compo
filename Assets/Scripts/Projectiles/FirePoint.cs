using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
  public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawnProjectile(){
      Debug.Log("shot");
      Instantiate(projectile, transform.position, transform.rotation);
    }
}
