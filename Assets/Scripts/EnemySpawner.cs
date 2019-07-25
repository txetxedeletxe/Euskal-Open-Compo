using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject Crab;
    public GameObject Blob;
    public GameObject Eye;
    public GameObject cafetera;
    public int spawnedCount;

    public void update(){
      spawnedCount =0;
      foreach (Transform ts in gameObject.GetComponentsInChildren<Transform>()){
        spawnedCount +=1;
      }
    }

  public void spawnEnemy(float cadency, int type)
    {
        if (type == 0)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject crab = Instantiate(Crab, position, this.transform.rotation);
            crab.transform.parent = transform;
        }
        else if (type == 1)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject blob = Instantiate(Blob, position, this.transform.rotation);
            blob.transform.parent = transform;
        }
        else if (type == 2)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject eye = Instantiate(Eye, position, this.transform.rotation);
            eye.GetComponent<FlyingEye>().Player = player;
            eye.transform.parent = transform;
        }else if (type == 3)
        {
          Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
          GameObject coffe = Instantiate(cafetera, position, this.transform.rotation);
          coffe.transform.parent = transform;
        }

    }

}
