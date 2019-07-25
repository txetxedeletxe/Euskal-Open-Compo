using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Live : MonoBehaviour
{
    public int lives;
    private bool canBeHit;
    private float countDown;
    public GameObject liveBars;
    private float timer;
    private int maxlives;
    // Start is called before the first frame update
    void Start()
    {
      timer =0;
        canBeHit = true;
        countDown = 1.5f;
        maxlives = lives;
        liveBars.GetComponent<LifeControler>().spawnbars(lives);
    }
    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      if(timer>=3f){
        timer=0;
        if (lives<maxlives){
          lives +=1;
          liveBars.GetComponent<LifeControler>().addLive();
        }
      }
        if (!canBeHit)
        {
            if (countDown <= 0)
            {
                canBeHit = true;
            }
            else
            {
                countDown -= Time.deltaTime;
            }
        }

        if (lives <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (canBeHit)
        {
            if (hitInfo.transform.tag == "bullet")
            {
              hit();

            }
        }
    }
    public void hit(){
      canBeHit = false;
      countDown = 0.5f;
      timer = 0f;

      lives -= 1;
      liveBars.GetComponent<LifeControler>().removeLife();

    }
}
