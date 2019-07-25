using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   private GameObject spawner;
    public GameObject jungle;
    public GameObject ruins;
    public GameObject desert;


    int enemyCount;
    int type;
    float speed;
    float cadency;
    private bool start;
    private int enemyTypes;
    private int enemySet;
    // Start is called before the first frame update
    void Start()
    {
        enemySet =1;
        spawner = transform.parent.GetChild(1).gameObject;
        enemyCount = enemySet;
        type = 1;
        cadency = 1;
        start = true;
        enemyTypes = 4;


    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            for(int i=0; i<=enemyCount; i++) {
                type = Mathf.RoundToInt(Random.Range(-0.5f, enemyTypes-1.5f));
                spawner.GetComponent<EnemySpawner>().spawnEnemy(cadency, type);
            }

            gameObject.GetComponent<SpeedController>().updateSpeed();
            enemyCount++;
            cadency-=0.02f;

            if (jungle.activeSelf && !ruins.activeSelf && !desert.activeSelf)
            {
                jungle.SetActive(false);
                ruins.SetActive(true);
                spawner.GetComponent<Spawner>().backGround=2;

            } else if (!jungle.activeSelf && ruins.activeSelf && !desert.activeSelf)
            {
                ruins.SetActive(false);
                desert.SetActive(true);
                spawner.GetComponent<Spawner>().backGround=0;
            } else if (!jungle.activeSelf && !ruins.activeSelf && desert.activeSelf)
            {
                desert.SetActive(false);
                jungle.SetActive(true);
                spawner.GetComponent<Spawner>().backGround=1;
            }


                start = false;
        }

        if (enemyCount <= 0)
        {
          enemySet +=1;
            start = true;
            enemyCount = enemySet;
        }
    }




    public void updateEnemyCount()
    {
        Debug.Log("enemySet:"+ enemySet);
        Debug.Log("enemyCount:" + enemyCount);
        enemyCount -= 1;
    }
}
