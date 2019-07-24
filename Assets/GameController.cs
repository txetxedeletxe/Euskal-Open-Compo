using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject spawner;
    public GameObject jungle;
    public GameObject ruins;
    public GameObject desert;


    int enemyCount;
    int type;
    float speed;
    float cadency;
    private bool start;
    private int enemyTypes;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = 1;
        type = 1;
        cadency = 1;
        start = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            for(int i=0; i<=enemyCount; i++) {
                type = Mathf.RoundToInt(Random.Range(0, enemyTypes));
                spawner.GetComponent<EnemySpawner>().spawnEnemy(cadency, type);
            }

            gameObject.GetComponent<SpeedController>().updateSpeed();
            enemyCount++;
            cadency-=0.02f;

            if (jungle.activeSelf && !ruins.activeSelf && !desert.activeSelf)
            {
                jungle.SetActive(false);
                ruins.SetActive(true);
               
            } else if (!jungle.activeSelf && ruins.activeSelf && !desert.activeSelf)
            {
                ruins.SetActive(false);
                desert.SetActive(true);
            } else if (!jungle.activeSelf && !ruins.activeSelf && desert.activeSelf)
            {
                desert.SetActive(false);
                jungle.SetActive(true);
            }


                start = false;
        }

        if (enemyCount <= 0)
        {
            start = true;
        }
    }




    public void updateEnemyCount()
    {
        enemyCount -= 1;
    }
}
