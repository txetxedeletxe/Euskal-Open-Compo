using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject Crab;
    public GameObject Blob;
    public GameObject Eye;

  public void spawnEnemy(float cadency, int type)
    {
        if (type == 0)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject crab = Instantiate(Crab, position, this.transform.rotation);
        }
        else if (type == 1)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject blob = Instantiate(Blob, position, this.transform.rotation);
        }
        else if (type == 2)
        {
            Vector3 position = new Vector3(Random.Range(-Screen.width / 2, Screen.width), Random.Range(-Screen.height / 2, Screen.height), 0);
            GameObject eye = Instantiate(Eye, position, this.transform.rotation);
            eye.GetComponent<FlyingEye>().Player = player;
        }

    }
  
}
